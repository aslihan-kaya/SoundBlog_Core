using SoundBlog_Core.Data;
using SoundBlog_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace SoundBlog_Core.Controllers
{
    public class TypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Type type)
        {
            _db.Add(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var ynl = _db.Types.Find(id);
            return View(ynl);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Type type)
        {
            _db.Update(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sil = _db.Types.FirstOrDefault(m => m.TypeID == id);
            return View(sil);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var sil = _db.Types.FirstOrDefault(m => m.TypeID == id);
            _db.Types.Remove(sil);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
