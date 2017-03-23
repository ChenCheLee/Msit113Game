using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    [MetadataType(typeof(tTradeMetadata))]
    public partial class tTrade
    {

        public class tTradeMetadata
        {
            [DisplayName("交易編號")]
            public int fTradeID { get; set; }
            [DisplayName("賣家名稱")]
            public int fSalerID { get; set; }

            //[DisplayName("商品中文名稱")]
            //public string fGameName_TC { get; set; }
            //[DisplayName("商品英文名稱")]
            //public string fGameName_EN { get; set; }
            //[DisplayName("商品名稱")]
            public int fProductID { get; set; }

            [DisplayName("商品圖片")]
            public byte[] fProductPicture { get; set; }
            [DisplayName("商品資訊")]
            public string fProductIfon { get; set; }
            [DisplayName("商品價格")]
            [Range(1, 10000, ErrorMessage = "價格要在1~10000之間")]
            [DisplayFormat(DataFormatString = "{0:c0}")]
            public Nullable<int> fProductPrice { get; set; }
            [DisplayName("上架日期")]
            public string fOnshelfDate { get; set; }
            [DisplayName("商品數量")]
            public Nullable<int> fProductQuantity { get; set; }
            [DisplayName("商品描述")]
            public string fProductDescription { get; set; }
            [DisplayName("商品地區")]
            public string fProductRegion { get; set; }
            [DisplayName("付款方式")]
            public string fPayment { get; set; }
            [DisplayName("聯絡方式")]
            public string fSalerContact { get; set; }
            [DisplayName("取貨方式")]
            public string fPickup { get; set; }

        }
    }
}