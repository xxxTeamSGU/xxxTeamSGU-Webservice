using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;
using WCF.Models;


namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_CTHDN" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_CTHDN.svc or Service_CTHDN.svc.cs at the Solution Explorer and start debugging.
    public class Service_CTHDN : IService_CTHDN
    {
        [WebMethod]
        public List<HoaDon> LayCTHDN(int MaHDN)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    List<HoaDon> list = new List<HoaDon>();
                    list = db.CTHDNs.Where(p => p.MaHDN == MaHDN).Select(p => new HoaDon
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _Mau = p.Mau.TenMau,
                        _MaSize = p.MaSize,
                        _Size = p.Size.Size1,
                        _SoLuong = (int)p.SL,
                        _GiaSP = (decimal)p.GiaNhap,


                    }).ToList();
                    if (list != null)
                        return list;
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        [WebMethod]
        public bool ThemCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia)
        {
            CTHDN CT = new CTHDN();
            CT.MaHDN = MaHDN;
            CT.MaSP = MaSP;
            CT.MaMau = MaMau;
            CT.MaSize = MaSize;
            CT.SL = SoLuong;
            CT.GiaNhap = (decimal)DonGia;

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.CTHDNs.Add(CT);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        [WebMethod]
        public bool SuaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.CTHDNs.Single(p => p.MaHDN == MaHDN && p.MaSP == MaSP);
                    if (item != null)
                    {
                        item.MaMau = MaMau;
                        item.MaSize = MaSize;
                        item.SL = SoLuong;
                        item.GiaNhap = (decimal)DonGia;
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        [WebMethod]
        public bool XoaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.CTHDNs.SingleOrDefault(p => p.MaHDN == MaHDN && p.MaSP == MaSP && p.MaSize == MaSize && p.MaMau == MaMau);
                    if (SpDelete != null)
                    {
                        db.CTHDNs.Remove(SpDelete);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}
