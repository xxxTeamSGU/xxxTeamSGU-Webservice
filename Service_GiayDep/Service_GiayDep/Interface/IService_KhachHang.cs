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
        List<KhachHang> TimKiemKhachHang(string HoTen,string SoDT,string Email);
        [OperationContract]
        List<KhachHang> TimKiemKhachHang_GioiTinh(string HoTen, string SoDT, string Email, int GioiTinh);
    }
}