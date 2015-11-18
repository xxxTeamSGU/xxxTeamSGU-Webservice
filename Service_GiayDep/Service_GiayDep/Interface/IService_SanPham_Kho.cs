using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace Service_GiayDep.Interface
{
     [ServiceContract]
    public interface IService_SanPham_Kho
    {
        [OperationContract]
        List<SanPham_Price> LayKhoTheoSP(int MaSP, int MaMau);
        [OperationContract]
        List<SanPham_Price> SanphammoiPartial();
        [OperationContract]
         List<SanPham_Price> SanphamkhuyenmaiPartial();
        
    }
}