//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIETFRUIT
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACH_HANG
    {
        public KHACH_HANG()
        {
            this.HOA_DON = new HashSet<HOA_DON>();
        }
    
        public string MA_KHACH_HANG { get; set; }
        public string HO_TEN { get; set; }
        public string GIOI_TINH { get; set; }
        public System.DateTime NGAY_SINH { get; set; }
        public string SO_DIEN_THOAI { get; set; }
        public string SCMND { get; set; }
        public int DIEM_TICH_LUY { get; set; }
        public string EMAIL { get; set; }
        public string DIA_CHI { get; set; }
        public byte[] ANH { get; set; }
    
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
    }
}
