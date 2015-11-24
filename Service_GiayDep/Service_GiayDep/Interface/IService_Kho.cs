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
        List<Kho> LayTatCaKho();
        [OperationContract]
        List<SanPham_Price> LayKhoTheoSP(int MaSP);
       // [OperationContract]
      //  bool NhapKho(int MaSP, int MaMau, int MaSize, int Soluong, decimal GiaBan, decimal GiaNhap);
        [OperationContract]
        bool NhapMoi(int MaSP, int Mau, int MaSize, int Soluong, decimal Gianhap);
        [OperationContract]
        bool CapNhat(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap);
        [OperationContract]
        bool CheckKho(int MaSP, int Mau, int MaSize);
        [OperationContract]
        bool ThemKho(int MaHDN);
        [OperationContract]
        bool CapNhatGiaBanMoi(int MaSP, int MaMau, decimal GiaBan);
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
