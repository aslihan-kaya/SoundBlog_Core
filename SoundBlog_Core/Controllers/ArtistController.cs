using Microsoft.AspNetCore.Mvc;
using SoundBlog.Models;
using SoundBlog_Core.Data;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ArtistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Artists.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Artist artist)
        {
            _db.Add(artist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var ynl = _db.Artists.Find(id);
            return View(ynl);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Artist artist)
        {
            _db.Update(artist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sil = _db.Artists.FirstOrDefault(m => m.ArtistID == id);
            return View(sil);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var sil = _db.Artists.FirstOrDefault(m => m.ArtistID == id);
            _db.Artists.Remove(sil);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
