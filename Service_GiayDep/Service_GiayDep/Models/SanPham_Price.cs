using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_GiayDep.Models
{
    public class SanPham_Price
    {
        private int MaSP;

        public int _MaSP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        private string TenSP;

        public string _TenSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        private int MaSize;

        public int _MaSize
        {
            get { return MaSize; }
            set { MaSize = value; }
        }
        private int MaMau;

        public int _MaMau
        {
            get { return MaMau; }
            set { MaMau = value; }
        }
        private decimal GiaSP;

        public decimal _GiaSP
        {
            get { return GiaSP; }
            set { GiaSP = value; }
        }
        public SanPham_Price()
        {

        }
    }
}