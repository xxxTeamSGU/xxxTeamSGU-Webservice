﻿using GiayDep.Service_SanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiayDep.Service_SanPham_Kho;

namespace GiayDep.Models
{
    public class giohang
    {
        Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
        Service_SanPham_Kho.Service_SanPham_Kho k = new Service_SanPham_Kho.Service_SanPham_Kho();
        Service_Kho.Service_Kho spk = new Service_Kho.Service_Kho();
        Service_Mau.Service_Mau mau = new Service_Mau.Service_Mau();
        //Service_Size.Service_Size s = new Service_Size.Service_Size();
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
            //var si = s.LaySizeTheoMa(size);
            isize = size;
            //itensize = si.Size1;
            SanPham sp = db.LayMa(MaSP);
            stensp = sp.TenSP;
           anhbia = sp.HinhAnh;
           var k = spk.LayGia(MaSP, MaMau);
            dongia = (decimal)k;
            soluong = 1;

        }
    }

}