using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWEShop.Models.EntityFramework;


namespace HWEShop.Controllers
{
    public class MainPageController : Controller
    {

        private HweEcommerceDBEntities db = new HweEcommerceDBEntities();

        // GET: MainPage
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}