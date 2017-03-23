using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameMVC.Models;

namespace Market.Areas.Market.Controllers
{
    public class ProductController : Controller
    {
        private GameAllEntities db = new GameAllEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SingleProduct()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(GameMVC.Models.tTrade _trade, HttpPostedFileBase ProductImage)
        {
            if (ProductImage != null)
            {
                var imgSize = ProductImage.ContentLength;//讀取圖片得知"圖片大小"
                byte[] imgByte = new byte[imgSize];//設一個byte陣列的空間塞給"圖片大小"
                ProductImage.InputStream.Read(imgByte, 0, imgSize);//讀"圖片byte"從0到"圖片大小"都讀出來
                _trade.fProductPicture = imgByte;//最後再塞給BytesImage

                db.tTrade.Add(_trade);//加進去存進資料庫
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "請上傳圖片檔案";
            ViewBag.datas = db.tTrade.ToList();
            return View();
        }
    }
}