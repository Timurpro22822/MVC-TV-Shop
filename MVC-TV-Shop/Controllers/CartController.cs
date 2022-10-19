using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TV_Shop.Helpers;
using System.Text.Json;

namespace MVC_TV_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly TvShopDbContext context;
        public CartController(TvShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) ids = new List<int>();

            List<TVModel?> tvs = ids.Select(id => context.TVs.Find(id)).ToList();

            return View(tvs);
        }
        public IActionResult Add(int id)
        {
            if (context.TVs.Find(id) == null) return NotFound();
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            
            if (ids == null) ids = new List<int>();

            ids.Add(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");

            if (ids == null) return NotFound();

            ids.Remove(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }

    }
}
