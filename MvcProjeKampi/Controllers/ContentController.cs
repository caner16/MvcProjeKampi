using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
       
       public ActionResult GetAllContent(string p)
        {
            var values = cm.GetList(p);                                                         //from x in c.Contents select x;
            //if (!string.IsNullOrEmpty(p))
            //{
            //    values = values.Where(y => y.ContentValue.Contains(p));
            //}
            
            
            return View(values.ToList());
           
     
          
           //var values = c.Contents.ToList();
            //return View(values);
        }
       
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues=cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}