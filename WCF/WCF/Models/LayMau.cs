namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]



    public partial class LayMau
    {
        [DataMember]
        private int MaSP;

        [DataMember]
        public int _MaSP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }

        [DataMember]
        private int MaMau;

        [DataMember]
        public int _MaMau
        {
            get { return MaMau; }
            set { MaMau = value; }
        }
        [DataMember]
        private string TenMau;

        [DataMember]
        public string _TenMau
        {
            get { return TenMau; }
            set { TenMau = value; }
        }
    }
}