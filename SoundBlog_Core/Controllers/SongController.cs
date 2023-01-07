using Microsoft.AspNetCore.Mvc;
using SoundBlog.Models;
using SoundBlog_Core.Data;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class SongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Songs.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Song song)
        {
            _db.Add(song);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var ynl = _db.Songs.Find(id);
            return View(ynl);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Song song)
        {
            _db.Update(song);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sil = _db.Songs.FirstOrDefault(m => m.SongID == id);
            return View(sil);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var sil = _db.Songs.FirstOrDefault(m => m.SongID == id);
            _db.Songs.Remove(sil);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}