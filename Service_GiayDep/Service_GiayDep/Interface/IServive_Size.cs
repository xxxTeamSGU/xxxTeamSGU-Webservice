using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IServive_Size
    {

        [OperationContract]
        List<Size> LayTatCaSize();
        [OperationContract]
        bool ThemSize(int Size);
        [OperationContract]
        bool SuaSize(int MaSize, int Size);
        [OperationContract]
        bool XoaSize(int MaSize);
    }
}
