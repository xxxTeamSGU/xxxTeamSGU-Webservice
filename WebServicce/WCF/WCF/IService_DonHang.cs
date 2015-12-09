using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_DonHang" in both code and config file together.
    [ServiceContract]
    public interface IService_DonHang
    {
        [OperationContract]
        int ThemDH(int MaKH, DateTime NgayMua, decimal TongTien, int TinhTrang, string NVDuyet);
        [OperationContract]
        List<DonHang> LichSuDH(int MaKH);
        [OperationContract]
        bool SuaDH(int MaDH, int TinhTrang);
        [OperationContract]
        List<HoaDonXuat> LayTatCaDonHang();
        [OperationContract]
        List<HoaDonXuat> TimDonHang(string x);
        [OperationContract]
        bool DuyetHD(int MaHDN,string NhanVien);
    }
}
