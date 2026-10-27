using Microsoft.AspNetCore.Mvc;
using day_3.Models;

namespace day_3.Controllers
{
    public class HomeController : Controller
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Phone" },
            new Category { Id = 3, Name = "Tablet" },
        };

        // GET: HomeController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}