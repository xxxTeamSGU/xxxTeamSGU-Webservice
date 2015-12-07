using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service_GiayDep.Models;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_CTDH" in both code and config file together.
    [ServiceContract]
    public interface IService_CTDH
    {
        [OperationContract]
        bool ThemCTDH(int MaDH, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia);
        [OperationContract]
        List<SanPham_Price> LsCTDH(int MaDH);
        [OperationContract]
        List<CTHDXuat> LayCTHDN(int MaHDN);
        [OperationContract]
        bool XoaCTDH(int MaDH, int MaSP, int MaMau, int MaSize);
    }
}
