using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreCRUDwithEFCore.Models;

namespace MVCCoreCRUDwithEFCore.Controllers
{
    public class LoaiController : Controller
    {
        private readonly MyDbContext db;

        public LoaiController(MyDbContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View(db.Loais.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Loai lo)
        {
            if(ModelState.IsValid)
            {
                db.Add(lo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(!id.HasValue)
                return NotFound();

            //LINQ query
            var lo = db.Loais.SingleOrDefault(p => p.MaLoai == id);
            if(lo == null)
            {
                return NotFound();
            }

            return View(lo);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Loai lo)
        {
            //Update loai
            db.Update(lo);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if(!id.HasValue)
            {
                return NotFound();
            }

            //remove loai by Id
            //LINQ query
            var lo = db.Loais.SingleOrDefault(p => p.MaLoai == id);
            if (lo == null)
            {
                return NotFound();
            }
            db.Remove(lo);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}