using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_KhachHang" in both code and config file together.
    [ServiceContract]
    public interface IService_KhachHang
    {
        [OperationContract]
        List<KhachHang> LayTatCaKhachHang();
        [OperationContract]
        bool XoaKhachHang(int MaKH);
        [OperationContract]
        List<KhachHang> TimKiemKhachHang(string HoTen, string SDT, string Email);
        [OperationContract]
        List<KhachHang> TimKiemKhachHang_GioiTinh(string HoTen, string SDT, string Email, string GioiTinh);
        [OperationContract]
        bool ThemKhachHang(string HoTen, DateTime NgaySinh, string Email, string MatKhau, string SDT, string DiaChi, string GioiTinh);
        [OperationContract]
        KhachHang Login(string email, string password);
        [OperationContract]
        bool CheckEmail(string Email);
        [OperationContract]
        bool SuaKhachHang(int MaKH, string HoTen, DateTime NgaySinh, string Email, string SDT, string DiaChi);
        [OperationContract]
        KhachHang LayKhachHang(int MaKH);
    }
}
