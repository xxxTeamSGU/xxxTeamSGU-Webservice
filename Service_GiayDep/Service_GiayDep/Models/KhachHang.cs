//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    [KnownType(typeof(DonHang))]
    public partial class KhachHang
    {
        public KhachHang()
        {
            this.DonHangs = new List<DonHang>();
        }

        [DataMember]
        public int MaKH { get; set; }
        [DataMember]
        public string HoTen { get; set; }
        [DataMember]
        public string SoDT { get; set; }
        [DataMember]
        public string SoTK { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string MatKhau { get; set; }

        [DataMember]
        public virtual List<DonHang> DonHangs { get; set; }
    }
}
