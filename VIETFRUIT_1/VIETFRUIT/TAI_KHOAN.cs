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
    
    public partial class TAI_KHOAN
    {
        public TAI_KHOAN()
        {
            this.TRANG_THAI = new HashSet<TRANG_THAI>();
        }
    
        public string MA_NHAN_VIEN { get; set; }
        public string TEN_TAI_KHOAN { get; set; }
        public string MAT_KHAU { get; set; }
    
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        public virtual ICollection<TRANG_THAI> TRANG_THAI { get; set; }
    }
}
