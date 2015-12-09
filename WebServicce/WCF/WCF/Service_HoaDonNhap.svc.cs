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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_HoaDonNhap" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_HoaDonNhap.svc or Service_HoaDonNhap.svc.cs at the Solution Explorer and start debugging.
    public class Service_HoaDonNhap : IService_HoaDonNhap
    {
        [WebMethod]
        public List<HoaDonNhap> LayTatCaHoaDon()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.HDNhaps.Select(p => new HoaDonNhap
                    {
                        _MaHDN = p.MaHDN,
                        _MaNCC = (int)p.MaNCC,
                        _NCC = p.NhaCungCap.TenNCC,
                        _MaNV = (int)p.MaNV,
                        _NhanVien = p.NhanVien.HoTen,
                        _NgayLap = (DateTime)p.NgayNhap,
                        _TinhTrang = (int)p.TinhTrang,
                        _TongTien = (int)p.TongTien

                    }).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }   
        [WebMethod]
        public List<HoaDonNhap> TimHoaDon(string x)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.HDNhaps.Select(p => new HoaDonNhap
                    {
                        _MaHDN = p.MaHDN,
                        _MaNCC = (int)p.MaNCC,
                        _NCC = p.NhaCungCap.TenNCC,
                        _MaNV = (int)p.MaNV,
                        _NhanVien = p.NhanVien.HoTen,
                        _NgayLap = (DateTime)p.NgayNhap,
                        _TinhTrang = (int)p.TinhTrang,
                        _TongTien = (int)p.TongTien

                    }).ToList();
                    return list.Where(p => p._NCC.Contains(x) || p._NhanVien.Contains(x)).ToList();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        [WebMethod]
        public int LayMotHoaDon()
        {
            int x = 0;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.HDNhaps.Select(p => p.MaHDN).Max();
                    x = list;
                    return x;

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return x;
            }
        }
        [WebMethod]
        public bool ThemHDN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang)
        {
            HDNhap HDN = new HDNhap();
            HDN.MaNCC = MaNCC;
            HDN.MaNV = MaNV;
            HDN.NgayNhap = DateTime.Parse(NgayLap);
            HDN.TongTien = (decimal)TongTien;
            HDN.TinhTrang = TinhTrang;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.HDNhaps.Add(HDN);
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
        public bool SuaHDN(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.HDNhaps.Single(p => p.MaHDN == MaHDN);
                    if (item != null)
                    {
                        item.MaNCC = MaNCC;
                        item.MaNV = MaNV;
                        item.NgayNhap = DateTime.Parse(NgayLap);
                        item.TongTien = (decimal)TongTien;
                        item.TinhTrang = TinhTrang;
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
        public bool XoaHDN(int MaHDN)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.CTHDNs.RemoveRange(db.CTHDNs.Where(p => p.MaHDN == MaHDN));
                    var SpDelete = db.HDNhaps.SingleOrDefault(p => p.MaHDN == MaHDN);
                    if (SpDelete != null)
                    {
                        db.HDNhaps.Remove(SpDelete);
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
        public bool DuyetHD(int MaHDN)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.HDNhaps.SingleOrDefault(p => p.MaHDN == MaHDN);
                    if (item != null)
                    {
                        item.TinhTrang = 1;
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
        public int ThemHDNVaTraVeMaDHN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang)
        {
            int MaHDN = 0;
            HDNhap HDN = new HDNhap();
            HDN.MaNCC = MaNCC;
            HDN.MaNV = MaNV;
            HDN.NgayNhap = DateTime.Parse(NgayLap);
            HDN.TongTien = (decimal)TongTien;
            HDN.TinhTrang = TinhTrang;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.HDNhaps.Add(HDN);
                    db.SaveChanges();
                    return MaHDN = HDN.MaHDN;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return MaHDN;
            }
        }

    }
}
