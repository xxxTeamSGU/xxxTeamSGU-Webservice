using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class LaySize
    {
        private int MaSize;

        public int _MaSize
        {
            get { return MaSize; }
            set { MaSize = value; }
        }
        private int Size1;

        public int _Size
        {
            get { return Size1; }
            set { Size1 = value; }
        }

    }
}