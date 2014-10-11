using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Message message)
        {
            if(ModelState.IsValid){
                return View("Confirmation", message);
            } else {
                return View();
            }
        }
	}
}