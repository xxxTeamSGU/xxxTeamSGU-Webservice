using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_HoaDonNhap
    {
        
        [OperationContract]
        List<HDNhap> LayTatCaHoaDon();
        [OperationContract]
        int ThemHDNVaTraVeMaDHN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        [OperationContract]
        bool SuaHDN(int MaHDN,int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        [OperationContract]
        bool XoaHDN(int MaHDN);
        [OperationContract]
        int LayMotHoaDon();
        [OperationContract]
        bool DuyetHD(int MaHDN);
    }
}