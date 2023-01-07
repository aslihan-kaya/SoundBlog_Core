using Microsoft.AspNetCore.Mvc;
using SoundBlog.Models;
using SoundBlog_Core.Data;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class AlbumController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AlbumController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Albums.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Album album)
        {
            _db.Add(album);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var ynl = _db.Albums.Find(id);
            return View(ynl);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Album album)
        {
            _db.Update(album);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sil = _db.Albums.FirstOrDefault(m => m.AlbumID == id);
            return View(sil);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var sil = _db.Albums.FirstOrDefault(m => m.AlbumID == id);
            _db.Albums.Remove(sil);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
