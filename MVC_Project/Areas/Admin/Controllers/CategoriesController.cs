using Microsoft.AspNetCore.Mvc;
using MVC_Project.Data;
using MVC_Project.Models;

namespace MVC_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();


        public IActionResult Index()
        {
            var Categores = context.Categories.ToList();
            return View(Categores);
        }
        public IActionResult Remove(int id)
        {
            var cat = context.Categories.Find(id);
            context.Categories.Remove(cat);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id) { 
            var cat = context.Categories.Find(id);
            return View(nameof(Edit),cat);
        }
        public IActionResult Update(Category category)
        {

            if (!ModelState.IsValid) { 
            return View(nameof(Edit),category);
            }
            var cat = context.Categories.Find(category.Id);
            cat.Name = category.Name;
            context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }
        public IActionResult Create() { 
            return View();
        }
        public IActionResult Store(Category category) { 
        
            if (!ModelState.IsValid)
            {
                return View(nameof(Create), category);
            }
            
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
