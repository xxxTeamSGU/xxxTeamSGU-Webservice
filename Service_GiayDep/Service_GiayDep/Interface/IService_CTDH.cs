using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service_GiayDep.Models;
using System.ServiceModel;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_CTDH
    {
        [OperationContract]
        bool ThemCTDH(int MaDH, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia);
    }
}