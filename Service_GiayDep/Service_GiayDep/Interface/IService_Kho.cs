using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
     public interface IService_Kho
    {
        [OperationContract]
       Kho LayKho(int masp);
        [OperationContract]
        List<LaySize> LaySize(int masp, int mamau);
        [OperationContract]
        List<LayMau> LayMau(int masp);
        [OperationContract]
        int LayGia(int MaSP, int MaMau);
        [OperationContract]
        List<LaySize> ChonMau(int MaSP, int MaMau);
       
   
    }
}
