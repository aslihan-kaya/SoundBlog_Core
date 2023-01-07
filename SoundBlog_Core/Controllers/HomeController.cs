using SoundBlog_Core.Data;
using SoundBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SoundBlog_Core.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

  
        
        
    }
}
