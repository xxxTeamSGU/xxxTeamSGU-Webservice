using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_SanPham_Kho" in both code and config file together.
    [ServiceContract]
    public interface IService_SanPham_Kho
    {
        [OperationContract]
        List<SanPham_Price> LayKhoTheoSP(int MaSP, int MaMau);
        [OperationContract]
        List<SanPham_Price> SanphammoiPartial();
        [OperationContract]
        List<SanPham_Price> SanphamkhuyenmaiPartial();
        [OperationContract]
        List<Kho> LayTatCa();
        [OperationContract]
        List<SanPham_Price> DanhMuc(string th, int maloai);
        [OperationContract]
        List<SanPham_Price> TimKiemSanPham(string Tim);
        [OperationContract]
        List<SanPham_Price> LayTatCaSP();
        [OperationContract]
        List<SanPham_Price> TimSanPham(string TenSP);

    }
}
