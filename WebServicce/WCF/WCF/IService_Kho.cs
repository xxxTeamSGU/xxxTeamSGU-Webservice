using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Kho" in both code and config file together.
    [ServiceContract]
    public interface IService_Kho
    {
        [OperationContract]
        List<Kho_SP> LayTatCaKho();

        [OperationContract]
        List<Kho_SP> TimKho(string x);
        [OperationContract]
        List<SanPham_Price> LayKhoTheoSP(int MaSP);
        [OperationContract]
        bool NhapMoi(int MaSP, int Mau, int MaSize, int Soluong, decimal Gianhap);
        [OperationContract]
        bool CapNhat(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap);
        [OperationContract]
        bool CapNhatBanHang(int MaSP, int Mau, int MaSize, int Soluong);
        [OperationContract]
        bool CheckKho(int MaSP, int Mau, int MaSize);
        [OperationContract]
        bool CheckSoLuong(int MaSP, int Mau, int MaSize, int SoLuong);
        [OperationContract]
        bool ThemKho(int MaHDN);
        [OperationContract]
        bool XuatKho(int MaHD,string NhanVien);
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
