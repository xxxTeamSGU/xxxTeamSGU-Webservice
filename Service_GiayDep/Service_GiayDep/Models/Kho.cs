//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [DataContract(IsReference = true)]
    public partial class Kho
    {
        [DataMember]
        public int MaSP { get; set; }
        [DataMember]
        public int MaMau { get; set; }
        [DataMember]
        public int MaSize { get; set; }
        [DataMember]
        public Nullable<int> SL { get; set; }
        [DataMember]
        public Nullable<decimal> GiaBan { get; set; }
        [DataMember]
        public Nullable<decimal> GiaNhap { get; set; }


        [DataMember]
        public virtual Mau Mau { get; set; }
        [DataMember]
        public virtual SanPham SanPham { get; set; }
        [DataMember]
        public virtual Size Size { get; set; }
    }
}
