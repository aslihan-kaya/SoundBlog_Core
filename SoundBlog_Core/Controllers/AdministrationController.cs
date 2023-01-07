using SoundBlog_Core.Data;
using SoundBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class AdministrationController : Controller
    {


        private readonly ApplicationDbContext _db;
        public AdministrationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
         
            return View();
        }
        public IActionResult Type()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }
        public IActionResult Artist()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }
        public IActionResult Album()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }
        public IActionResult Song()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }
        public IActionResult Company()
        {
            var listele = _db.Types.ToList();
            return View(listele);
        }
    }
}
