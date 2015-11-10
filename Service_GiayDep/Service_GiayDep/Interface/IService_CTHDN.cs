using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    interface IService_CTHDN
    {
        [OperationContract]
        List<CTHDN> LayCTHDN(int MaHDN);
        [OperationContract]
        bool ThemCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        [OperationContract]
        bool SuaCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        [OperationContract]
        bool XoaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize);
    }
}
