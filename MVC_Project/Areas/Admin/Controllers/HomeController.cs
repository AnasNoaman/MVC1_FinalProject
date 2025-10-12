using Microsoft.AspNetCore.Mvc;
using MVC_Project.Data;

namespace MVC_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();


        public IActionResult Index()
        {
            var Categores = context.Categories.ToList();
            return View(Categores);
        }
    }
}
