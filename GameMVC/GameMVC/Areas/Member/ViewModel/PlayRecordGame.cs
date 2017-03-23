using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W.Areas.Member.ViewModel
{
    public class PlayRecordGame
    {
        [DisplayName("遊戲")]
        public string fGameName_TC { get; set; }


        public int fPlayRecordID { get; set; }


        public int fMemberID { get; set; }


        public int fGameID { get; set; }

        [DisplayName("日期")]
        [DataType(DataType.Date)]
        public System.DateTime fPlayDate { get; set; }

        [DisplayName("地點")]
        public string fPlayLocation { get; set; }

        [DisplayName("次數")]
        public int fPlayCount { get; set; }

        [DisplayName("描述")]
        [DataType(DataType.MultilineText)]
        public string fPlayDescription { get; set; }


        public string fKey { get; set; }

        
    }
}