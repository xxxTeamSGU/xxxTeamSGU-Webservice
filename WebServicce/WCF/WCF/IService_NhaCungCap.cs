using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_NhaCungCap" in both code and config file together.
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
        [OperationContract]
        bool CheckNhaCungCap(string TenNCC);
    }
}
