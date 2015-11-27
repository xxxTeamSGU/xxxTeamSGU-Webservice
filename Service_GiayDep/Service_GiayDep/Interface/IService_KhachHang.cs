using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_KhachHang
    {
        [OperationContract]
        List<KhachHang> LayTatCaKhachHang();
        [OperationContract]
        bool XoaKhachHang(int MaKH);
        [OperationContract]
        List<KhachHang> TimKiemKhachHang(string HoTen,string SDT,string Email);
        [OperationContract]
        List<KhachHang> TimKiemKhachHang_GioiTinh(string HoTen, string SDT, string Email, string GioiTinh);
        [OperationContract]
        bool ThemKhachHang(string HoTen, DateTime NgaySinh, string Email, string MatKhau, string SDT, string DiaChi, string GioiTinh, DateTime NgayDangKi);
        [OperationContract]
        KhachHang Login(string email, string password);
    }
}