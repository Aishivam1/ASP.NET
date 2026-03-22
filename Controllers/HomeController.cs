using System;
using System.Web.Mvc;

namespace ASPNETApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Message = "Welcome to ASP.NET MVC 5!";
            ViewBag.ApplicationName = "ASP.NET MVC Welcome Application";
            ViewBag.CurrentDate = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm tt");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "About this ASP.NET MVC 5 Application";
            ViewBag.Description = "This is a sample application built with ASP.NET MVC 5 (.NET Framework 4.5.2)";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "Contact Us";
            return View();
        }
    }
}
