using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_HoaDonNhap" in both code and config file together.
    [ServiceContract]
    public interface IService_HoaDonNhap
    {
        [OperationContract]
        List<HoaDonNhap> LayTatCaHoaDon();
        [OperationContract]
        List<HoaDonNhap> TimHoaDon(string x);
        [OperationContract]
        bool ThemHDN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        [OperationContract]
        bool SuaHDN(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        [OperationContract]
        bool XoaHDN(int MaHDN);
        [OperationContract]
        int LayMotHoaDon();
        [OperationContract]
        bool DuyetHD(int MaHDN);
        [OperationContract]
        int ThemHDNVaTraVeMaDHN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
    }

}
