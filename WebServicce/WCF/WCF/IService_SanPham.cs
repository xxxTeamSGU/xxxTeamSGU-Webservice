using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService_SanPham
    {
        [OperationContract]
        List<SanPham> LayTatCaSanPham();
        [OperationContract]
        bool ThemSanPham(string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT);
        [OperationContract]
        bool SuaSanPham(int MaSP, string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT);
        [OperationContract]
        bool XoaSanPham(int MaSP);
        [OperationContract]
        List<SanPham> TimKiemSanPham(string Tim);
        [OperationContract]
        SanPham LayMa(int masp);
        [OperationContract]
        List<TH> ThuongHieuNam();
        [OperationContract]
        List<TH> ThuongHieuNu();
        [OperationContract]
        List<TH> ThuongHieuTreEm();
        [OperationContract]
        List<SanPham> SanphammoiPartial();
        [OperationContract]
        List<SanPham> SanphamkhuyenmaiPartial();
        [OperationContract]
        SanPham Chitietsanpham(int masp);
        [OperationContract]
        SanPham LaySanPham(int imasp);
        [OperationContract]
        bool CheckSanPham(string TenSP);
    }
}
