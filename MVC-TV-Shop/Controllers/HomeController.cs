using Microsoft.AspNetCore.Mvc;
using Data;
using MVC_TV_Shop.Models;
using System.Diagnostics;

namespace MVC_TV_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly TvShopDbContext context;

        public HomeController(TvShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var tvs = context.TVs.ToList();

            return View(tvs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}