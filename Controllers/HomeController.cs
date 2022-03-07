using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using OlympicGames.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context;

        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGame = "all", string activeSport = "all")
        {
            var session = new TeamSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveSport(activeSport);

            //If no count in session, get cookie and restore favorite teams in session
            int? count = session.GetMyTeamCount();
            if (count == null)
            {
                var cookies = new TeamCookies(Request.Cookies);
                string[] ids = cookies.GetMyTeamIds();

                List<Team> myteams = new List<Team>();
                if (ids.Length > 0)
                {
                    myteams = context.Teams.Include(t=>t.Game)
                        .Include(t=>t.Sport)
                        .Where(t=>ids.Contains(t.TeamId)).ToList();
                }
                else
                {
                    session.SetMyTeams(myteams);

                }
                session.SetMyTeams(myteams);
            }

            var model = new TeamListViewModel
            {
                ActiveGame = activeGame,
                ActiveSport = activeSport,
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList()
            };
            //Get teams - filter by game and sport
            IQueryable<Team> query = context.Teams;
            if (activeGame != "all")
                query=query.Where(
                    t => t.Game.GameId.ToLower() == activeGame.ToLower());
            if (activeSport != "all")
                query=query.Where(
                    t => t.Sport.SportId.ToLower() == activeSport.ToLower());

            //pass teams to the view as model
            model.Teams = query.ToList();
            return View(model);
        }



        [HttpPost]
        public RedirectToActionResult Details(TeamViewModel model)
        {
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSport"] = model.ActiveSport;
            return RedirectToAction("Details", new { ID = model.Team.TeamId });
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
            var session = new TeamSession(HttpContext.Session);
            var model = new TeamViewModel
            {
                Team = context.Teams
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .FirstOrDefault(t => t.TeamId == id),
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
            };
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Add(TeamViewModel model)
        {
            model.Team = context.Teams
                .Include(t=>t.Game)
                .Include(t=>t.Sport)
                .Where(t=>t.TeamId==model.Team.TeamId)
                .FirstOrDefault();

            var session = new TeamSession(HttpContext.Session);
            var teams = session.GetMyTeams();
            teams.Add(model.Team);
            session.SetMyTeams(teams);

            var cookies = new TeamCookies(Response.Cookies);
            cookies.SetMyTeamIds(teams);

            TempData["message"] = $"{model.Team.Name} added to your favorites";
            return RedirectToAction("Index", new
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
            });
        }
    }
}
