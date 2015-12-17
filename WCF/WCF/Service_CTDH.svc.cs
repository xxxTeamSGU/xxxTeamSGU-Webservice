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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_CTDH" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_CTDH.svc or Service_CTDH.svc.cs at the Solution Explorer and start debugging.
    public class Service_CTDH : IService_CTDH
    {
        [WebMethod]
        public bool ThemCTDH(int MaDH, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia)
        {
            CTDH ctdh = new CTDH();
            ctdh.MaDH = MaDH;
            ctdh.MaSP = MaSP;
            ctdh.MaMau = MaMau;
            ctdh.MaSize = MaSize;
            ctdh.SL = SoLuong;
            ctdh.DonGia = (decimal)DonGia;

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.CTDHs.Add(ctdh);
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
        public List<SanPham_Price> LsCTDH(int MaDH)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var ct = db.CTDHs.Where(n => n.MaDH == MaDH).Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = (int)p.Size.Size1,
                        _GiaSP = (decimal)p.DonGia,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
                        _SL = (int)p.SL,
                    }).ToList();

                    return ct;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        [WebMethod]
        public List<CTHDXuat> LayCTHDN(int Mahd)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.CTDHs.Where(p => p.MaDH == Mahd).Select(p => new CTHDXuat
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _Mau = p.Mau.TenMau,
                        _MaSize = p.MaSize,
                        _Size = (int)p.Size.Size1,
                        _SoLuong = (int)p.SL,
                        _GiaSP = (decimal)p.DonGia,

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
        public bool XoaCTDH(int MaDH, int MaSP, int MaMau, int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.CTDHs.SingleOrDefault(p => p.MaDH == MaDH && p.MaSP == MaSP && p.MaSize == MaSize && p.MaMau == MaMau);
                    if (SpDelete != null)
                    {
                        db.CTDHs.Remove(SpDelete);
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
