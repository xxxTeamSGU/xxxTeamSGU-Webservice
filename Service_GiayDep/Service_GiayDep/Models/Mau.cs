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
    
    public partial class Mau
    {
        public Mau()
        {
            this.CTDHs = new List<CTDH>();
            this.CTHDNs = new List<CTHDN>();
            this.Khoes = new List<Kho>();
        }
    
        public int MaMau { get; set; }
        public string TenMau { get; set; }
    
        public virtual List<CTDH> CTDHs { get; set; }
        public virtual List<CTHDN> CTHDNs { get; set; }
        public virtual List<Kho> Khoes { get; set; }
    }
}
