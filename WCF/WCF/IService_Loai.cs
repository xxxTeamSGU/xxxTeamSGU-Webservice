using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Loai" in both code and config file together.
    [ServiceContract]
    public interface IService_Loai
    {
        [OperationContract]
        List<Loai> LayTatCaLoai();
        [OperationContract]
        bool ThemLoai(string TenLoai);
        [OperationContract]
        bool SuaLoai(int MaLoai, string TenLoai);
        [OperationContract]
        bool XoaLoai(int MaLoai);
        [OperationContract]
        bool CheckLoai(string TenLoai);
    }
}
