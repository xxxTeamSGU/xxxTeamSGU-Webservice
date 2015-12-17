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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_DonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_DonHang.svc or Service_DonHang.svc.cs at the Solution Explorer and start debugging.
    public class Service_DonHang : IService_DonHang
    {
        [WebMethod]
        public int ThemDH(int MaKH, DateTime NgayMua, decimal TongTien, int TinhTrang, string NVDuyet)
        {
            DonHang dh = new DonHang();
            dh.MaKH = MaKH;
            dh.NgayMua = (DateTime)NgayMua;
            dh.TongTien = (decimal)TongTien;
            dh.TinhTrang = TinhTrang;
            dh.NVDuyet = NVDuyet;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.DonHangs.Add(dh);
                    db.SaveChanges();
                    return dh.MaDH;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return 0;
            }
        }
        [WebMethod]
        public List<DonHang> LichSuDH(int MaKH)
        {

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var ls = db.DonHangs.Where(n => n.MaKH == MaKH).ToList();
                    return ls;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        [WebMethod]
        public bool SuaDH(int MaDH, int TinhTrang)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.DonHangs.Single(p => p.MaDH == MaDH);
                    if (item != null)
                    {
                        //item.MaKH = MaKH;
                        //item.NgayMua = DateTime.Parse(NgayMua);
                        //item.TongTien = (decimal)TongTien;
                        item.TinhTrang = TinhTrang;
                        //item.NVDuyet = NVDuyet;
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
        public List<HoaDonXuat> LayTatCaDonHang()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.DonHangs.Select(p => new HoaDonXuat
                    {
                        _MaHDN = p.MaDH,
                        _MaKH = (int)p.MaKH,
                        _KhachHang = p.KhachHang.HoTen,
                        _NhanVien = p.NVDuyet,
                        _NgayLap = (DateTime)p.NgayMua,
                        _TinhTrang = (int)p.TinhTrang,
                        _TongTien = (int)p.TongTien
                    }).OrderBy(p => p._NgayLap).ToList();
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
        public bool DuyetHD(int MaHD)
        {

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.DonHangs.SingleOrDefault(p => p.MaDH == MaHD);
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
    }
}
