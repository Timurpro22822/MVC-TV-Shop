using Microsoft.AspNetCore.Mvc;
using Data;
using MVC_TV_Shop.Models;
using System.Diagnostics;
using MVC_TV_Shop.ViewModels;
using MVC_TV_Shop.Helpers;

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
            var tvs = context.TVs.Select(l => new TVCardViewModel()
            {
                TVModel = l,
            }).ToList();

            foreach (var item in tvs)
            {
                item.IsInCart = IsProductInCart(item.TVModel.Id);
            }

            return View(tvs);
        }
        private bool IsProductInCart(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) return false;

            return ids.Contains(id);
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