using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using GameMVC.Models;

namespace MVCgroup2.Areas.揪團.Controllers
{
    public class GroupController : Controller
    {
        private GameAllEntities db = new GameAllEntities();
        private GameMVC.Areas.揪團.Models.PairRepository<tPair> repository = new GameMVC.Areas.揪團.Models.PairRepository<tPair>();
        private GameMVC.Areas.揪團.Models.PairRepository<tMember> repository1 = new GameMVC.Areas.揪團.Models.PairRepository<tMember>();
        private tPairJoinMember tp = new tPairJoinMember();
        //private tPairJoinMember1 tp1 = new tPairJoinMember1();
        // GET: 揪團/Group
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(tPair _tpair, tMember _tmemeber)
        {
            repository.Create(_tpair);
            repository1.Create(_tmemeber);
            return RedirectToAction("Index");
        }
        //Todo 把JOIN語法 把PairJoinMembers語法帶出團
        public ActionResult MyPair()
        {
            //var tpairJoinMemberID = from ca in db.tPairJoinMembers
            //                        select ca.fMemberID;

            GameMVC.Areas.揪團.Models.tPairJoinMember1 tp2 = new GameMVC.Areas.揪團.Models.tPairJoinMember1();
            var fmemberid = from ss in db.tMember
                            where ss.fMemberID == tp.fMemberID
                    select ss.fMemberID;
            //tPairJoinMember1 tp1 = new tPairJoinMember1();

            //List<tPairJoinMember1> tpairjoinM = fmemberid;


            tp2.fmemberID = fmemberid.Single();

            return View(tp2);
    
         }
 
        public ActionResult Delete(int id = 0)
        {
            repository.Delete(repository.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(repository.GetById(id));
        }
        [HttpPost]
        public ActionResult Edit(tPair _tpair)
        {
            repository.Update(_tpair);
            return RedirectToAction("Index");
        }
    }
}