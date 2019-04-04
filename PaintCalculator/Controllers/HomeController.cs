using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaintCalculator.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Models.HomeViewModel hvm = new Models.HomeViewModel();
            hvm.Room = new DTO.Room();
            hvm.Paint = new DTO.Paint();



            return View(hvm);
        }
        // Postback. This rebinds the Room and Paint objects to calculate the areas and volumes
        [HttpPost]
        public ActionResult Index(Models.HomeViewModel hvm)
        {
            return View(hvm);
        }


        // Partial Views Allowing for multiple doors and windows.
        public PartialViewResult Door()
        {
            return PartialView("_Door", new DTO.Door());
        }
        public PartialViewResult Window()
        {
            return PartialView("_Window", new DTO.Window());
        }


    }
}