using System.Linq;
using GameList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameList.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context { get; set; }
        public HomeController(GameContext ctx)
        {
            context = ctx;
        }
     
        public IActionResult Index()
        {
            var games = context.Games.OrderBy(x => x.Name).ToList();
            return View(games);
        }

      

    }
}