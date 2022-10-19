using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            //var tv = context.TVs.ToList();
            var tvs = context.TVs.Include(l => l.Color).ToList();

            return View(tvs);
        }
        public IActionResult Details(int id)
        {
            //var tv = MockData.GetTVById(id);
            TVModel? tv = context.TVs.Find(id);

            if (tv == null) return NotFound();

            ViewBag.ReturnUrl = Request.Headers["Referer"].ToString();

            return View(tv);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TVModel? tVModel = context.TVs.Find(id);

            //if (tVModel == null) return NotFound();

            //return View(tVModel);

            TVModel? tVModel = context.TVs.Find(id);
            if(tVModel == null) return NotFound();
            SetColors();
            return View(tVModel);
        }
        //private void SetColors()
        //{
        //    var colorsList = context.Color
        //}
        [HttpPost]
        public IActionResult Edit(TVModel tVModel)
        {
            if(!ModelState.IsValid)
            {
                SetColors();
                return View(tVModel);
            }

            context.TVs.Update(tVModel);
            context.SaveChanges();

            TempData["alertMessage"] = "Product was edited!";

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int id)
        {
            //context.TVs.Remove(id);
            //if (tv == null) return NotFound();
            //var tv = MockData.DeleteTVById(id);

            TVModel? tVModel = context.TVs.Find(id);
            if (tVModel == null) return NotFound();
            context.TVs.Remove(tVModel);
            context.SaveChanges();

            TempData["alertMessage"] = "Product was deleted!";

            return RedirectToAction(nameof(Index));
            //return View("Index");
        }
        [HttpGet] // by default
        public IActionResult Create()
        {
            return View();
        }

        private void SetColors()
        {
            var colorsList = context.Colors.ToList();
            ViewBag.ColorsList = new SelectList(colorsList, nameof(Color.Id), nameof(Color.Name));
        }

        [HttpPost]
        public IActionResult Create(TVModel tvmodel)
        {
            if (!ModelState.IsValid)
            {
                SetColors();
                return View(tvmodel);
            }

            context.TVs.Add(tvmodel);
            context.SaveChanges();

            TempData["alertMessage"] = "Product was create!";

            return RedirectToAction(nameof(Index));
        }
    }
}
