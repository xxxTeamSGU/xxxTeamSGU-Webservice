using GiayDep.Service_SanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiayDep.Service_SanPham_Kho;

namespace GiayDep.Models
{
    public class giohang
    {
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        Service_SanPham_Kho.Service_SanPham_KhoClient k = new Service_SanPham_Kho.Service_SanPham_KhoClient();
        Service_Kho.Service_KhoClient spk = new Service_Kho.Service_KhoClient();
        Service_Mau.Service_MauClient mau = new Service_Mau.Service_MauClient();
        Service_Size.Service_SizeClient s = new Service_Size.Service_SizeClient();
        public int ID { get; set; }
        public int imasp{ get; set;}
        public int imamau { get; set; }
        public string itenmau { get; set; }
        public string stensp { get; set; }
        public int isize { get; set; }
        public int itensize { get; set; }
        public string anhbia { get; set; }
        public decimal dongia { get; set; }
        public int soluong { get; set; }
        public decimal thanhtien {
            get {
                return soluong * dongia;
            }
        }
        public giohang(int MaSP, int MaMau, int size)
        {
            ID = 1;
            imasp = MaSP;
            var m = mau.LayMauTheoMa(MaMau);
            imamau = MaMau;
            itenmau = m.TenMau ;
            var si = s.LaySizeTheoMa(size);
            isize = size;
            itensize = (int)si.Size1;
            var sp = db.LayMa(MaSP);
            stensp = sp.TenSP;
           anhbia = sp.HinhAnh;
           var k = spk.LayGia(MaSP, MaMau);
            dongia = (decimal)k;
            soluong = 1;

        }
    }

}