using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    public interface IService_NhaCungCap
    {
        [OperationContract]
        List<NhaCungCap> LayTatCaNhaCungCap();
        [OperationContract]
        bool ThemNhaCungCap(string TenNCC, string DiaChi, string SoDT, string SoTK);
        [OperationContract]
        bool SuaNhaCungCap(int MaNCC, string TenNCC, string DiaChi, string SoDT, string SoTK);
        [OperationContract]
        bool XoaNhaCungCap(int MaNCC);
        [OperationContract]
        List<NhaCungCap> TimKiemNhaCungCap(string x);
    }
}