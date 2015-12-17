namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class LaySize
    {
        [DataMember]
        private int MaSize;

        [DataMember]
        public int _MaSize
        {
            get { return MaSize; }
            set { MaSize = value; }
        }
        [DataMember]
        private int Size1;

        [DataMember]
        public int _Size
        {
            get { return Size1; }
            set { Size1 = value; }
        }
        
    }
}