using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_KhuyenMai" in both code and config file together.
    [ServiceContract]
    public interface IService_KhuyenMai
    {
        [OperationContract]
        List<KhuyenMai> LayTatCaKM();
        [OperationContract]
        bool ThemKM(string TenKM, DateTime NgayBD, DateTime NgayKT);
        [OperationContract]
        bool SuaKM(int MaKM, string TenKM, DateTime NgayBD, DateTime NgayKT);
        [OperationContract]
        bool XoaKM(int MaKM);
        [OperationContract]
        bool CheckKhuyenMai(string TenKM);
    }
}
