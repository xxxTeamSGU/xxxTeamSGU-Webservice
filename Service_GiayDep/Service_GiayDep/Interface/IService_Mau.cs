using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    interface IService_Mau
    {
        [OperationContract]
        List<Mau> LayTatCaMau();
        [OperationContract]
        bool ThemMau(string Mau);
        [OperationContract]
        bool SuaMau(int MaMau, string Mau);
        [OperationContract]
        bool XoaMau(int MaMau);
    }
}
