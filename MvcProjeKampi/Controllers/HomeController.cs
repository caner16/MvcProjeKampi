using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        // GET: Home
        public ActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult HomePage()
        {
            var files = ifm.GetList();
            return View(files);
        }
        public ActionResult SweatAlert()
        {
           
            return View();
        }


        // GET: Gallery

    }
}