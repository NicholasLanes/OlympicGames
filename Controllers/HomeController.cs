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
            var model = new TeamViewModel
            {
                Team = context.Teams
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .FirstOrDefault(t => t.TeamId == id),
                ActiveGame = TempData.Peek("ActiveGame").ToString() ?? "all",
                ActiveSport = TempData.Peek("ActiveSport").ToString() ?? "all"
            };
            return View(model);
        }
    }
}
