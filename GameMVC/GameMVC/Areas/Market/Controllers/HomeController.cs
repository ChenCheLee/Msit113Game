
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GameMVC.Models;

namespace Market.Areas.Market.Controllers
{
    public class HomeController : Controller
    {
        private GameAllEntities db = new GameAllEntities();
        
        // GET: Market/Home
        public ActionResult Index()
        {
            Response.Cookies["site"].Value = Request.Url.AbsolutePath;
            Request.Cookies["site"].Expires = DateTime.Now.AddHours(1);
            if(Request.Cookies["account"] == null)
            {
                return RedirectToAction("Login", "Home", new { area = "Member" });
            }
            
            return View();
        }

        public ActionResult Slider()
        {
            return PartialView(db.tTrade.ToList());
        }

        public ActionResult Productwidget()
        {
            return PartialView();
        }
    }
}