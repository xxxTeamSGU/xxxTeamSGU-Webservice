using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_CTHDN" in both code and config file together.
    [ServiceContract]
    public interface IService_CTHDN
    {
        [OperationContract]
        List<HoaDon> LayCTHDN(int MaHDN);
        [OperationContract]
        bool ThemCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        [OperationContract]
        bool SuaCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        [OperationContract]
        bool XoaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize);
    }
}
