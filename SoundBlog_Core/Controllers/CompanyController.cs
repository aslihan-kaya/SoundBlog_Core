using Microsoft.AspNetCore.Mvc;
using SoundBlog.Models;
using SoundBlog_Core.Data;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CompanyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Companies.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Company company)
        {
            _db.Add(company);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var ynl = _db.Companies.Find(id);
            return View(ynl);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Company company)
        {
            _db.Update(company);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sil = _db.Companies.FirstOrDefault(m => m.CompanyID == id);
            return View(sil);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var sil = _db.Companies.FirstOrDefault(m => m.CompanyID == id);
            _db.Companies.Remove(sil);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
