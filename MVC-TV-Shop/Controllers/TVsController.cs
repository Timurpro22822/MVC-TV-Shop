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
        public IActionResult Create(int? id)
        {
            TVModel tvmodel = context.TVs.Find(id);
            return View(tvmodel);
            //return View();
        }
        public IActionResult Delete(int id)
        {
            //context.TVs.Remove(id);
            //if (tv == null) return NotFound();
            //var tv = MockData.DeleteTVById(id);

            var product = context.TVs.Find(id);
            if (product == null) return NotFound();
            context.TVs.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
            //return View("Index");
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
