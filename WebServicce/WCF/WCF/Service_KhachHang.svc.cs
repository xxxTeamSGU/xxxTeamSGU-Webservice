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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_KhachHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_KhachHang.svc or Service_KhachHang.svc.cs at the Solution Explorer and start debugging.
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
        public bool ThemKhachHang(string HoTen, DateTime NgaySinh, string Email, string MatKhau, string SDT, string DiaChi, string GioiTinh)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = HoTen;
            kh.NgaySinh = NgaySinh;
            kh.Email = Email;
            kh.MatKhau = MatKhau;
            kh.SDT = SDT;
            kh.DiaChi = DiaChi;
            kh.GioiTinh = GioiTinh;
            kh.NgayDangKi = DateTime.Now;
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
            KhachHang login = db.KhachHangs.SingleOrDefault(n => n.Email == email && n.MatKhau == password);
            return login;
        }
        [WebMethod]
        public bool CheckEmail(string Email)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.KhachHangs.SingleOrDefault(p => p.Email.Equals(Email));
                    if (check != null)
                        return true;
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
        public bool SuaKhachHang(int MaKH, string HoTen, DateTime NgaySinh, string Email,  string SDT, string DiaChi)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.KhachHangs.Single(p => p.MaKH == MaKH);
                    if (item != null)
                    {
                        if (!HoTen.Equals(""))
                        {
                            item.HoTen = HoTen;
                        }
                        if (!NgaySinh.Equals(""))
                        {
                            item.NgaySinh = NgaySinh;
                        }
                        if (!Email.Equals(""))
                        {
                            item.Email = Email;
                        }
                      
                        if (!SDT.Equals(""))
                        {
                            item.SDT = SDT;
                        }
                        if (!DiaChi.Equals(""))
                        {
                            item.DiaChi = DiaChi;
                        }


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
        public KhachHang LayKhachHang(int MaKH)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    KhachHang list = db.KhachHangs.SingleOrDefault(p => p.MaKH == MaKH);
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
