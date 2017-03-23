using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameMVC.Areas.Gamewiki.Controllers
{
    public class WikiController : Controller
    {
        // GET: Gamewiki/Wiki
        public ActionResult Index()
        {
            return View();
        }

        //遊戲新增頁面
        public ActionResult GameInsert()
        {
            return View();
        }

        //遊戲資訊頁面
        public ActionResult GameView()
        {
            return View();
        }

        //遊戲編輯頁面
        public ActionResult GameEdit()
        {
            return View();
        }
    }
}