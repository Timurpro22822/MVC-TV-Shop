using Microsoft.AspNetCore.Mvc;
using MVC_TV_Shop.Data;
using MVC_TV_Shop.Models;

namespace MVC_TV_Shop.Controllers
{
    public class TvsController : Controller
    {
        private readonly TvShopDbContext context;

        public TvsController(TvShopDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            //var tv = MockData.GetTVs();
            var tv = context.TVs.ToList();

            return View(tv);
        }
        public IActionResult Details(int id)
        {
            //var tv = MockData.GetTVById(id);
            TVModel? tv = context.TVs.Find(id);

            if (tv == null) return NotFound();

            return View(tv);
        }
        
        [HttpGet] // by default
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TVModel TVModel)
        {
            if (!ModelState.IsValid) return View(TVModel);

            context.TVs.Add(TVModel);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
