﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_SanPham
    {
        [OperationContract]
        List<SanPham> LayTatCaSanPham();
        [OperationContract]
        bool ThemSanPham(string TenSP,int MaLoai,string ThuongHieu,string Size,
            string MauSac,decimal GiaSP,string HinhAnh,string HinhAnh1,
            string HinhAnh2,string HinhAnh3, int SoLuong, string MoTa,int KM,string NgayCapNhat);
        [OperationContract]
        bool SuaSanPham(int MaSP, string TenSP, int MaLoai, string ThuongHieu, string Size,
            string MauSac, decimal GiaSP, string HinhAnh, string HinhAnh1,
            string HinhAnh2, string HinhAnh3, int SoLuong, string MoTa, int KM, string NgayCapNhat);
        [OperationContract]
        bool XoaSanPham(int MaSP);
        [OperationContract]
        List<SanPham> TimKiemSanPham(string Tim);
    }
}