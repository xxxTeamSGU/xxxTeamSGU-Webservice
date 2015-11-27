using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;
namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_DonHang
    {
        [OperationContract]
        int ThemDH( int MaKH, DateTime NgayMua, decimal TongTien, int TinhTrang, string NVDuyet);
    }
}