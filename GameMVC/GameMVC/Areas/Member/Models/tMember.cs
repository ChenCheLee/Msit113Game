//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace W.Areas.Member.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tMember()
        {
            this.tActiveRegionVSMember = new HashSet<tActiveRegionVSMember>();
            this.tWishlist = new HashSet<tWishlist>();
            this.tPlayRecord = new HashSet<tPlayRecord>();
        }
    
        public int fMemberID { get; set; }
        public string fMemberAccount { get; set; }
        public string fMemberPassWord { get; set; }
        public string fMemberEmail { get; set; }
        public string fMemberName { get; set; }
        public string fMemberNickName { get; set; }
        public string fMemberGender { get; set; }
        public Nullable<int> fMemberPermission { get; set; }
        public string fMemberPhone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tActiveRegionVSMember> tActiveRegionVSMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tWishlist> tWishlist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPlayRecord> tPlayRecord { get; set; }
    }
}
