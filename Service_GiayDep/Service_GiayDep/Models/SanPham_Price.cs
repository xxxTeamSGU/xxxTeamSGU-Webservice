namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]



    public partial class SanPham_Price
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



        private string TenSP;

        public string _TenSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        private int Size;

        public int _Size
        {
            get { return Size; }
            set { Size = value; }
        }
        private string TenMau;

        public string _TenMau
        {
            get { return TenMau; }
            set { TenMau = value; }
        }
        private decimal GiaSP;

        public decimal _GiaSP
        {
            get { return GiaSP; }
            set { GiaSP = value; }
        }
        
        private string HinhAnh;
        public string _HinhAnh
        {
            get { return HinhAnh; }
            set { HinhAnh = value; }
        }

       
    }

}