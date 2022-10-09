using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            TVModel? tVModel = context.TVs.Find(id);

            if (tVModel == null) return NotFound();

            return View(tVModel);
        }
        [HttpPost]
        public IActionResult Edit(TVModel tVModel)
        {
            context.TVs.Update(tVModel);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

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
        [HttpGet] // by default
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TVModel tvmodel)
        {
            if (!ModelState.IsValid) return View(tvmodel);

            context.TVs.Add(tvmodel);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
