using Microsoft.AspNetCore.Mvc;
using OlympicGames.Models;

namespace OlympicGames.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new TeamSession(HttpContext.Session);
            var model = new TeamListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                Teams = session.GetMyTeams()
            };
            return View(model);
        }
        
        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new TeamSession(HttpContext.Session);
            var cookies = new TeamCookies(Response.Cookies);

            session.RemoveMyTeams();
            cookies.RemoveMyTeamIds();

            TempData["message"] = "Favorite teams cleared.";
            return RedirectToAction("Index", "Home", new{
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport()
            });
        }
    }
}
