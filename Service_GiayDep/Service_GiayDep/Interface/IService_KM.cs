using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    interface IService_KM
    {
        [OperationContract]
        List<Loai> LayTatCaKM();
        [OperationContract]
        bool ThemKM(string TenKM,DateTime NgayBD, DateTime NgayKT);
        [OperationContract]
        bool SuaKM(int MaKM, string TenKM,DateTime NgayBD,DateTime NgayKT);
        [OperationContract]
        bool XoaKM(int MaKM);
    }
}
