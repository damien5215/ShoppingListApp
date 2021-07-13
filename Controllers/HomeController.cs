using ShoppingListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingListApp.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingRepository repo = ShoppingRepository.Current;

        public ViewResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Add(ShoppingList item) 
        {
            if (ModelState.IsValid)
            {
                repo.Add(item);
                return RedirectToAction("Index");
            }
            else 
            {
                return View("Index");
            }
        }

        public ActionResult Remove(int Id) 
        {
            repo.Remove(Id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(ShoppingList item) 
        {
            if (ModelState.IsValid && repo.Update(item))
            {
                return RedirectToAction("Index");
            }
            else 
            {
                return View("Index");
            }
        }

    }
}