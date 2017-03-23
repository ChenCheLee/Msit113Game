using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameMVC.Models;
using GameMVC.ViewModel;

namespace GameMVC.Controllers
{
    public class HomeController : Controller
    {
        private GameAllEntities db = new GameAllEntities();
        // GET: Home/Home
        public ActionResult Index()
        {            
            return View();
        }
        public ActionResult Logout()
        {
            Session["site"] = "fff";
            Response.Cookies["account"].Expires = DateTime.Now.AddMilliseconds(1);
            return RedirectToAction("Index");
        }
        public ActionResult GameCard(int id=0)
        {
            if(id==1)
                return PartialView(db.tGame.OrderByDescending(g=>g.fGameID).Take(10).ToList());
            else
                return PartialView(db.tGame.OrderByDescending(g=>g.fRank).Take(10).ToList());
            }
        public ActionResult GetImageByte(int id)
        {
            tGameFile gameFile = db.tGameFile.Where(g=>g.fGameID==id).First();
            byte[] img = gameFile.fGameFileBinary;
            return File(img, "image/jpeg");
        }
    }
}