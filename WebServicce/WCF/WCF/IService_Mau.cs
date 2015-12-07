using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Mau" in both code and config file together.
    [ServiceContract]
    public interface IService_Mau
    {
        [OperationContract]
        List<Mau> LayTatCaMau();
        [OperationContract]
        bool ThemMau(string Mau);
        [OperationContract]
        bool SuaMau(int MaMau, string Mau);
        [OperationContract]
        bool XoaMau(int MaMau);
        [OperationContract]
        Mau LayMauTheoMa(int MaMau);
    }
}
