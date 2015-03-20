using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wireframe.Models;


namespace wireframe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            if (ModelState.IsValid)
            {
                InsertContact(model.Name, model.Address, model.City, model.Email, model.Message);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void InsertContact(string name, string Address, string city, string email, string message)
        {
            throw new NotImplementedException();
        }
        
        

        
    }
}