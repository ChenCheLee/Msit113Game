using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W.Areas.Member.Models
{
    [MetadataType(typeof(tMemberMetadata))]
    public partial class tMember
    {
        public class tMemberMetadata
        {

            
            //public int fMemberID { get; set; }

            [DisplayName("帳號")]
            [Required(ErrorMessage = "產品型號要輸入")]
            public string fMemberAccount { get; set; }

            [DisplayName("密碼")]
            [Required(ErrorMessage = "密碼要輸入")]
            public string fMemberPassWord { get; set; }

            [DisplayName("電子郵件")]
            [Required(ErrorMessage = "電子郵件要輸入")]
            public string fMemberEmail { get; set; }

            [DisplayName("姓名")]
            public string fMemberName { get; set; }

            [DisplayName("暱稱")]
            public string fMemberNickName { get; set; }

            [DisplayName("性別")]
            public string fMemberGender { get; set; }


            //public Nullable<int> fMemberPermission { get; set; }

            [DisplayName("電話")]
            public string fMemberPhone { get; set; }

        
        }
    }
}