//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhatTreHan
    {
        public int MaPhat { get; set; }
        public Nullable<int> MaDocGia { get; set; }
        public Nullable<int> MaMuonSach { get; set; }
        public Nullable<System.DateTime> NgayPhat { get; set; }
        public Nullable<int> SoTienPhat { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        public virtual MuonSach MuonSach { get; set; }
    }
}