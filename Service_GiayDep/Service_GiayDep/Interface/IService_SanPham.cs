using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;
using System.ServiceModel.Web;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_SanPham
    {
        [OperationContract]
        List<SanPham> LayTatCaSanPham();
        [OperationContract]
        bool ThemSanPham(string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT);
        [OperationContract]
        bool SuaSanPham(int MaSP, string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT);
        [OperationContract]
        bool XoaSanPham(int MaSP);
        [OperationContract]
        List<SanPham> TimKiemSanPham(string Tim);
        [OperationContract]
        List<SanPham> SanphammoiPartial();
        [OperationContract]
        List<SanPham> SanphamkhuyenmaiPartial();
        [OperationContract]
        SanPham Chitietsanpham(int masp);
        [OperationContract]
        SanPham LaySanPham(int imasp);
    }
}