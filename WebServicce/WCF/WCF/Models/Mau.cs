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
    [KnownType(typeof(CTHDN))]
    [KnownType(typeof(CTDH))]
    [KnownType(typeof(Kho))]
    public partial class Mau
    {
        public Mau()
        {
            this.CTDHs = new List<CTDH>();
            this.CTHDNs = new List<CTHDN>();
            this.Khoes = new List<Kho>();
        }

        [DataMember]
        public int MaMau { get; set; }
        [DataMember]
        public string TenMau { get; set; }

        [DataMember]
        public virtual List<CTDH> CTDHs { get; set; }
        [DataMember]
        public virtual List<CTHDN> CTHDNs { get; set; }
        [DataMember]
        public virtual List<Kho> Khoes { get; set; }
    }
}
