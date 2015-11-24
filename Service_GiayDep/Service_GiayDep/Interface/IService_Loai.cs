using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
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