using ViewsPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good Morning!" : "Good Afternoon!";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestReponse guestReponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks!", guestReponse);
            }
            else
            {
                //Validation error
                return View();
            }
        }

    }
}