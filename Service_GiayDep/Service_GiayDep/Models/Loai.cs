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
    [KnownType(typeof(SanPham))]


    public partial class Loai
    {
        public Loai()
        {
            this.SanPhams = new List<SanPham>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }


        public virtual List<SanPham> SanPhams { get; set; }
    }
}
