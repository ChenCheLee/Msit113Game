//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tTrade
    {
        public int fTradeID { get; set; }
        public int fSalerID { get; set; }
        public int fProductID { get; set; }
        public byte[] fProductPicture { get; set; }
        public string fProductIfon { get; set; }
        public Nullable<int> fProductPrice { get; set; }
        public string fOnshelfDate { get; set; }
        public Nullable<int> fProductQuantity { get; set; }
        public string fProductDescription { get; set; }
        public string fProductRegion { get; set; }
        public string fPayment { get; set; }
        public string fSalerContact { get; set; }
        public string fPickup { get; set; }
        public string fKey { get; set; }
    
        public virtual tGame tGame { get; set; }
    }
}
