using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]



    public partial class LayMau
    {
        private int MaSP;

        public int _MaSP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }

        private int MaMau;

        public int _MaMau
        {
            get { return MaMau; }
            set { MaMau = value; }
        }
        private string TenMau;

        public string _TenMau
        {
            get { return TenMau; }
            set { TenMau = value; }
        }
    }
}