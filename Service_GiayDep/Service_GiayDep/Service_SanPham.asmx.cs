using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Service_GiayDep.Interface;
using Service_GiayDep.Models;
using System.Diagnostics;

namespace Service_GiayDep
{
    /// <summary>
    /// Summary description for Service_SanPham
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_SanPham : IService_SanPham
    {

        [WebMethod]
        public List<SanPham> LayTatCaSanPham()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = (db.SanPhams.Select(p => p).ToList());
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
        public bool ThemSanPham(string TenSP,int MaLoai,string ThuongHieu,string Size,string MauSac,decimal GiaSP,
            string HinhAnh,string HinhAnh1,string HinhAnh2,string HinhAnh3, int SoLuong, string MoTa,int KM,string NgayCapNhat)
        {
            SanPham sanpham = new SanPham();
            sanpham.TenSP = TenSP;
            sanpham.MaLoai = (int)MaLoai;
            sanpham.ThuongHieu = ThuongHieu;
            sanpham.Size = Size;
            sanpham.MauSac = MauSac;
            sanpham.GiaSP = (decimal)GiaSP;
            sanpham.HinhAnh = HinhAnh;
            sanpham.HinhAnh1 = HinhAnh1;
            sanpham.HinhAnh2 = HinhAnh2;
            sanpham.HinhAnh3 = HinhAnh3;
            sanpham.SoLuong = (int)SoLuong;
            sanpham.MoTa = MoTa;
            sanpham.KM = (int)KM;
            sanpham.NgayCapNhat = DateTime.Parse(NgayCapNhat);
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.SanPhams.Add(sanpham);
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
        public bool SuaSanPham(int MaSP, string TenSP, int MaLoai, string ThuongHieu, string Size,
       string MauSac, decimal GiaSP, string HinhAnh, string HinhAnh1,
       string HinhAnh2, string HinhAnh3, int SoLuong, string MoTa, int KM, string NgayCapNhat)
        {
           
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.SanPhams.Single(p => p.MaSP == MaSP);
                    if (item != null)
                    {
                        item.TenSP = TenSP;
                        item.MaLoai = (int)MaLoai;
                        item.ThuongHieu = ThuongHieu;
                        item.Size = Size;
                        item.MauSac = MauSac;
                        item.GiaSP = GiaSP;
                        item.HinhAnh = HinhAnh;
                        item.HinhAnh1 = HinhAnh1;
                        item.HinhAnh2 = HinhAnh2;
                        item.HinhAnh3 = HinhAnh3;
                        item.SoLuong = (int)SoLuong;
                        item.MoTa = MoTa;
                        item.KM = (int)KM;
                        db.SaveChanges();
                        return true;
                    }
                    else
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
        public bool XoaSanPham(int MaSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.SanPhams.SingleOrDefault(p =>p.MaSP == MaSP);
                    if(SpDelete!=null)
                    {
                        db.SanPhams.Remove(SpDelete);
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
        public List<SanPham> TimKiemSanPham(string Tim)
        {
            try
            {
                using(DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.SanPhams.Where( c => c.TenSP.Contains(Tim) || c.ThuongHieu.Contains(Tim)).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
    
    }
}
