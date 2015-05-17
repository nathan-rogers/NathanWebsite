using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Active = "about";

            return View();
        }
        [HttpPost]
        public ActionResult About(HttpPostedFileBase file)
        {
            try
            {
                var filename = Guid.NewGuid().ToString().Substring(0,5) + "_" + Path.GetFileName(file.FileName);
                var filenamePath = Path.Combine(Server.MapPath("~/Content/Uploads"), filename);
                file.SaveAs(filenamePath);//saves file
                ViewBag.Message = "Good job";
            }
            catch (Exception e)
            {
                ViewBag.Message = "Bad Job" + e.Message;
                
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}