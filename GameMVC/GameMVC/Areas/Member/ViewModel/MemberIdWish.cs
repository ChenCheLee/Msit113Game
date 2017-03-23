using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace W.Areas.Member.ViewModel
{
    public class MemberIdWish
    {
        public int fWishlistID { get; set; }
        public string fGameName_TC { get; set; }
        public int fGameID { get; set; }
        public bool fWantToPlay { get; set; }
        public bool fWantToBuy { get; set; }
        public bool fWantToSale { get; set; }
        public bool fOwn { get; set; }
    }
}