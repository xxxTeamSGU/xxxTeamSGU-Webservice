using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Size" in both code and config file together.
    [ServiceContract]
    public interface IService_Size
    {
        [OperationContract]
        List<Size> LayTatCaSize();
        [OperationContract]
        bool ThemSize(int Size);
        [OperationContract]
        bool SuaSize(int MaSize, int Size);
        [OperationContract]
        bool XoaSize(int MaSize);
        [OperationContract]
        Size LaySizeTheoMa(int MaSize);
    }
}
