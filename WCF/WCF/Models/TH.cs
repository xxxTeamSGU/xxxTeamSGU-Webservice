namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]

    public partial class TH
    {
        [DataMember]
        private string ThuongHieu;
        [DataMember]
        public string _ThuongHieu
        {
            get { return ThuongHieu; }
            set { ThuongHieu = value; }
        }
    
    }
}