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
    [KnownType(typeof(HoaDonNhap))]

    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.HoaDonNhaps = new List<HoaDonNhap>();
        }

        [DataMember]
        public int MaNCC { get; set; }
        [DataMember]
        public string TenNCC { get; set; }
        [DataMember]
        public string DiaChi { get; set; }
        [DataMember]
        public string SoDT { get; set; }
        [DataMember]
        public string SoTK { get; set; }

        [DataMember]
        public virtual List<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
