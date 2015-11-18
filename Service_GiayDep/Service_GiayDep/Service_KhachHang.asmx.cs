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
    /// Summary description for Service_KhachHang
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_KhachHang : IService_KhachHang
    {

        DBGiayDepEntities db = new DBGiayDepEntities();
         [WebMethod]
        public List<KhachHang> LayTatCaKhachHang()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.KhachHangs.Select(p => p).ToList();
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
        public bool XoaKhachHang(int MaKH)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.KhachHangs.SingleOrDefault(p => p.MaKH == MaKH);
                    if (SpDelete != null)
                    {
                        db.KhachHangs.Remove(SpDelete);
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
        public List<KhachHang> TimKiemKhachHang_GioiTinh(string HoTen, string SDT, string Email, string GioiTinh)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.KhachHangs.Where(c => c.HoTen.Contains(HoTen) && c.SDT.Contains(SDT) && c.Email.Contains(Email) && c.GioiTinh == GioiTinh).ToList();
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
        public List<KhachHang> TimKiemKhachHang(string HoTen, string SDT, string Email)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.KhachHangs.Where(c => c.HoTen.Contains(HoTen) && c.SDT.Contains(SDT) && c.Email.Contains(Email)).ToList();
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
        public bool ThemKhachHang(string HoTen,DateTime NgaySinh,  string Email, string MatKhau,string SDT, string DiaChi, string GioiTinh ,DateTime NgayDangKi)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = HoTen;
            kh.NgaySinh = NgaySinh;
            kh.Email = Email;
            kh.MatKhau = MatKhau;
            kh.SDT = SDT;
            kh.DiaChi = DiaChi;
            kh.GioiTinh = GioiTinh;
            kh.NgayDangKi = NgayDangKi;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //Lưu add kh mới vào model
                    db.KhachHangs.Add(kh);
                    //Lưu vào CSDL
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
        public KhachHang Login(string email, string password)
        {
            KhachHang login = db.KhachHangs.SingleOrDefault(n=>n.Email == email && n.MatKhau==password);
            return login;
        }
        
    }
}
