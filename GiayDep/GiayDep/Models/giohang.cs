using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiayDep.Models
{
    public class giohang
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        public int ID { get; set; }
        public int imasp{ get; set;}
        public string stensp { get; set; }
        public string anhbia { get; set; }
        public double dongia { get; set; }
        public int soluong { get; set; }
        public double thanhtien {
            get {
                return soluong * dongia;
            }
        }
        public giohang(int masp)
        {
            ID = 1;
            imasp = masp;
            SanPham sp = db.SanPhams.Single(n=>n.MaSP == imasp);
            stensp = sp.TenSP;
            anhbia = sp.HinhAnh;
            dongia = double.Parse(sp.GiaSP.ToString());
            soluong = 1;

        }
    }

}