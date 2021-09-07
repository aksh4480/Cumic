using Cumic.Services;
using CumicEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cumic.Web.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService categoryService  = new CategoriesService();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
          
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
            return View();

        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryService.GetCategory(ID);

            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            return View();

        }
    }
}