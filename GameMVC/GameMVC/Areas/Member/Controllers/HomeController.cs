using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W.Areas.Member.ViewModel;
using PagedList;
using PagedList.Mvc;
using GameMVC.Models;

namespace W.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        GameAllEntities db = new GameAllEntities();
        //GameEntities db = new GameEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tMember member,string remember)
        {
            var user = db.tMember.Where(m => m.fMemberAccount == member.fMemberAccount && m.fMemberPassWord == member.fMemberPassWord).FirstOrDefault();
           
            if (user != null)
            {
               
                Response.Cookies["account"].Value = user.fMemberID.ToString();
                
                if (remember== "yes")
                {
                    Response.Cookies["account"].Expires = DateTime.Now.AddDays(7);
                }

                ViewBag.message = "登入成功!!";
                if (Request.Cookies["site"] != null)
                    return Redirect(Request.Cookies["site"].Value);
                else
                    return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                ViewBag.message = "帳號密碼錯誤請重新輸入!!";
            }
            return View();
        }

        public ActionResult UpdateWishlist()
        {
            int MemberID = Convert.ToInt32(Request.Cookies["account"].Value);
            int gameid = Convert.ToInt32(Request.QueryString["gameid"]);
            string want= Request.QueryString["want"];

            var q = db.tWishlist.ToList().Where(c => c.fMemberID == MemberID && c.fGameID == gameid).FirstOrDefault();
            tWishlist _wishlist = db.tWishlist.Find(q.fWishlistID);

            if (want=="play")
            {
                _wishlist.fWantToPlay = false;
                db.Entry(_wishlist).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            if (want == "buy")
            {
                _wishlist.fWantToBuy = false;
                db.Entry(_wishlist).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            if (want == "sale")
            {
                _wishlist.fWantToSale = false;
                db.Entry(_wishlist).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            if (want == "own")
            {
                _wishlist.fOwn = false;
                db.Entry(_wishlist).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            TempData["gamename"] = db.tGame.Select(c => c.fGameName_TC).ToList();
            return RedirectToAction("LoginAfter", "Home", new { area = "Member" });
        }


        public ActionResult AddWishlist(tWishlist wishlist)
        {
            //TempData["insertMessage"] = "";
            tWishlist w = new tWishlist();
            int MemberID= Convert.ToInt32(Request.Cookies["account"].Value);
            w.fMemberID = MemberID;
            w.fGameID = wishlist.fGameID;
            
            if (wishlist.fWantToPlay == true)
                w.fWantToPlay = true;
            if (wishlist.fWantToBuy == true)
                w.fWantToBuy = true;
            if (wishlist.fWantToSale == true)
                w.fWantToSale = true;
            if (wishlist.fOwn == true)
                w.fOwn = true;

            var q = db.tWishlist.Where(c => c.fMemberID == MemberID && c.fGameID == wishlist.fGameID).FirstOrDefault();
            if (q == null)
            {
                db.tWishlist.Add(w);
                db.SaveChanges();
            }
            else
            {
                tWishlist _wishlist = db.tWishlist.Find(q.fWishlistID);
                if (w.fWantToPlay == true)
                    _wishlist.fWantToPlay = true;
                if (w.fWantToBuy == true)
                    _wishlist.fWantToBuy = true;
                if (w.fWantToSale == true)
                    _wishlist.fWantToSale = true;
                if (w.fOwn == true)
                    _wishlist.fOwn = true;

                db.Entry(_wishlist).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            TempData["gamename"] = db.tGame.Select(c => c.fGameName_TC).ToList();
            //TempData["insertMessage"] = "已存在";
            return RedirectToAction("LoginAfter", "Home", new { area = "Member" });
        }
        public ActionResult LoginAfter(int id=14)
        {                      
            List<MemberIdWish> mws = new List<MemberIdWish>();
            var wish = db.tWishlist.Where(c => c.fMemberID == id);

            foreach (var p in wish)
            {
                MemberIdWish mw = new MemberIdWish();
                var game = db.tGame.Find(p.fGameID);

                mw.fGameID = Convert.ToInt32(p.fGameID);
                mw.fWishlistID = p.fWishlistID;
                mw.fGameName_TC = game.fGameName_TC;
                mw.fWantToPlay = Convert.ToBoolean(p.fWantToPlay);
                mw.fWantToBuy = Convert.ToBoolean(p.fWantToBuy);
                mw.fWantToSale = Convert.ToBoolean(p.fWantToSale);
                mw.fOwn = Convert.ToBoolean(p.fOwn);
                mws.Add(mw);
            }
            TempData["gamename"] = db.tGame.Select(c => c.fGameName_TC).ToList();
            return View(mws);
        }

        public ActionResult LoadGameName()
        {
            return PartialView(db.tGame.ToList());
        }

        public ActionResult DeletePlayRecord(int PlayRecordId)
        {
            tPlayRecord _playRecord = db.tPlayRecord.Find(PlayRecordId);
            db.tPlayRecord.Remove(_playRecord);
            db.SaveChanges();
            return RedirectToAction("PlayRecord","Home",new {id=Convert.ToInt32(Request.Cookies["account"].Value)});
        }

        public ActionResult AddPlayRecord(tPlayRecord _playrecord)
        {
            _playrecord.fMemberID = Convert.ToInt32(Request.Cookies["account"].Value);
            db.tPlayRecord.Add(_playrecord);
            db.SaveChanges();
            return RedirectToAction("PlayRecord", "Home", new { id = Convert.ToInt32(Request.Cookies["account"].Value) });
        }

        public ActionResult UpdatePlayRecord()
        {
    
            

            tPlayRecord _playrecord = db.tPlayRecord.Find(Convert.ToInt32(Request.QueryString["recordid"]));           
            _playrecord.fGameID= Convert.ToInt32(Request.QueryString["gameid"]);
            _playrecord.fPlayDate = Convert.ToDateTime(Request.QueryString["date"]);
            _playrecord.fPlayLocation = Request.QueryString["location"].ToString();
            _playrecord.fPlayCount = Convert.ToInt32(Request.QueryString["count"]);
            _playrecord.fPlayDescription = Request.QueryString["description"].ToString();



            db.Entry(_playrecord).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PlayRecord", "Home", new { id = Convert.ToInt32(Request.Cookies["account"].Value) });
        }

        public ActionResult PlayRecord(int? page,int id=14)
        {
            var playRecord = db.tPlayRecord.Where(c => c.fMemberID == id);
            List<PlayRecordGame> pgs = new List<PlayRecordGame>();
            foreach (var c in playRecord.ToList())
            {
                PlayRecordGame pg = new PlayRecordGame();

                tGame game = db.tGame.Find(c.fGameID);

                pg.fGameID = Convert.ToInt32(c.fGameID);
                pg.fPlayRecordID = c.fPlayRecordID;
                pg.fGameName_TC = game.fGameName_TC;
                pg.fPlayDate = Convert.ToDateTime(c.fPlayDate);
                pg.fPlayLocation = c.fPlayLocation;
                pg.fPlayCount = Convert.ToInt32(c.fPlayCount);
                pg.fPlayDescription = c.fPlayDescription;
                pg.fKey = c.fKey;
                pg.fMemberID = Convert.ToInt32(c.fMemberID);
                pgs.Add(pg);

            }
            ViewBag.tGame = db.tGame.ToList();
            return View(pgs.ToPagedList(page ?? 1,5));
        }
    }
}