using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    interface IServive_Size
    {

        [OperationContract]
        List<Loai> LayTatCaSize();
        [OperationContract]
        bool ThemSize(string Size);
        [OperationContract]
        bool SuaSize(int MaSize, string Size);
        [OperationContract]
        bool XoaSize(int MaSize);
    }
}
