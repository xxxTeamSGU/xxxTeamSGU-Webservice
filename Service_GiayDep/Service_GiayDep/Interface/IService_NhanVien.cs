using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_NhanVien
    {
        [OperationContract]
        List<NhanVien> LayTatCaNhaNhanVien();
        [OperationContract]
        bool ThemNhanVien(string HoTen, string Email, string SoDT, string CMND, string DiaChi , string MatKhau, int QuyenAdmin);
        [OperationContract]
        bool SuaNhanVien(int MaNV, string HoTen, string Email, string SoDT, string CMND, string DiaChi, string MatKhau, int QuyenAdmin);
        [OperationContract]
        bool XoaNhanVien(int MaNV);
        [OperationContract]
        List<NhanVien> TimKiemNhanVien(string x);
        [OperationContract]
        bool KiemTraNhanVien(string Email, string MatKhau);
        [OperationContract]
        List<NhanVien> LayMotNhanVien(string Email, string MatKhau);
    }
}