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
    /// Summary description for Service_NhanVien
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_NhanVien : IService_NhanVien
    {

        [WebMethod]
        public List<NhanVien> LayTatCaNhaNhanVien()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.NhanViens.Select(p => p).ToList();
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
        public bool ThemNhanVien(string HoTen, string Email, string SoDT, string CMND, string DiaChi, string MatKhau)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = HoTen;
            nv.Email = Email;
            nv.SoDT = SoDT;
            nv.CMND = CMND;
            nv.DiaChi = DiaChi;
            nv.MatKhau = MatKhau;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.NhanViens.Add(nv);
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
        public bool SuaNhanVien(int MaNV, string HoTen, string Email, string SoDT, string CMND, string DiaChi, string MatKhau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.NhanViens.Single(p => p.MaNV == MaNV);
                    if (item != null)
                    {
                        if (!HoTen.Equals(""))
                        {
                            item.HoTen = HoTen;
                        }
                        if (!Email.Equals(""))
                        {
                            item.Email = Email;
                        }
                        if (!SoDT.Equals(""))
                        {
                            item.SoDT = SoDT;
                        }
                        if (!CMND.Equals(""))
                        {
                            item.CMND = CMND;
                        }
                        if(!DiaChi.Equals(""))
                        {
                            item.DiaChi = DiaChi;
                        }
                        if (!MatKhau.Equals(""))
                        {
                            item.MatKhau = MatKhau;
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
        public bool XoaNhanVien(int MaNV)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.NhanViens.SingleOrDefault(p => p.MaNV == MaNV);
                    if (SpDelete != null)
                    {
                        db.NhanViens.Remove(SpDelete);
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
        public List<NhanVien> TimKiemNhanVien(string HoTen, string Email, string SoDT, string CMND, string DiaChi)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.NhanViens.Where(c => c.HoTen.Contains(HoTen) && c.Email.Contains(Email) && c.SoDT.Contains(SoDT) && c.CMND.Contains(CMND) && c.DiaChi.Contains(DiaChi)).ToList();
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
        public bool KiemTraNhanVien(string Email, string MatKhau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.NhanViens.SingleOrDefault(c => c.Email == Email && c.MatKhau == MatKhau);
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
        public List<NhanVien> LayMotNhanVien(string Email, string MatKhau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var nhanvien = db.NhanViens.Where(c => c.Email.Contains(Email) && c.MatKhau.Contains(MatKhau)).ToList();
                    if (nhanvien != null)
                        return nhanvien;
                    return null;

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
