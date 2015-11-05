using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Service_GiayDep.Models;

namespace Service_GiayDep.Interface
{
    [ServiceContract]
    interface IService_Kho
    {
        [OperationContract]
        public List<Kho> LayTatCaKho();
        [OperationContract]
        public List<Kho> LayKhoTheoSP(int MaSP);
        [OperationContract]
        public List<Kho> LayKhoTheoSize(int MaSize);
        [OperationContract]
        public bool NhapKho(int MaSP, int MaMau, int MaSize, int Soluong, decimal GiaBan, decimal GiaNhap);
        [OperationContract]
        public bool CapNhatKho(int MaSP, int MaMau, int MaSize, int Soluong, decimal GiaBan, decimal GiaNhap);
    }
}
