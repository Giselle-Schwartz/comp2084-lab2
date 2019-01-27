using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Categories()
        {   //a new List of type Category
            var categories = new List<Category>();
            //predefined string List of category names
            string[] categores = { "Food", "Tech", "Sports" };
            //loop through the categories List
            for (int i = 0; i <= 2; i++)
            {   //make a new Category object
                Category category = new Category();
                //use the values in categores to assign Name values
                category.Name = categores[i];
                //add em to the categories List
                categories.Add(category);
            }
            //show the page with the category names listed
            return View(categories);

        }

        public ActionResult Details(string CategoryName)
        {
            ViewBag.CategoryName = CategoryName;
           
            return View();
        }
    }
}