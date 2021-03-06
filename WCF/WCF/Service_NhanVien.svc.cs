﻿using Service_GiayDep.Models;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_NhanVien" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_NhanVien.svc or Service_NhanVien.svc.cs at the Solution Explorer and start debugging.
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
        public bool ThemNhanVien(string HoTen, string Email, string MatKhau, string DiaChi, string SDT, string CMND, int QuyenAdmin)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = HoTen;
            nv.Email = Email;
            nv.MatKhau = MatKhau;
            nv.DiaChi = DiaChi;
            nv.SDT = SDT;
            nv.CMND = CMND;
            nv.QuyenAdmin = QuyenAdmin;
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
        public bool SuaNhanVien(int MaNV, string HoTen, string Email, string MatKhau, string DiaChi, string SDT, string CMND, int QuyenAdmin)
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
                        if (!SDT.Equals(""))
                        {
                            item.SDT = SDT;
                        }
                        if (!CMND.Equals(""))
                        {
                            item.CMND = CMND;
                        }
                        if (!DiaChi.Equals(""))
                        {
                            item.DiaChi = DiaChi;
                        }
                        if (!MatKhau.Equals(""))
                        {
                            item.MatKhau = MatKhau;
                        }
                        item.QuyenAdmin = QuyenAdmin;
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
        public List<NhanVien> TimKiemNhanVien(string x)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.NhanViens.Where(c => c.HoTen.Contains(x) || c.Email.Contains(x) || c.SDT.Contains(x) || c.CMND.Contains(x) || c.DiaChi.Contains(x)).ToList();
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
        public NhanVien LayMotNhanVien(string Email, string MatKhau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var nhanvien = db.NhanViens.Where(c => c.Email.Contains(Email) && c.MatKhau.Contains(MatKhau)).SingleOrDefault();
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
        [WebMethod]
        public bool CheckEmail(string Email)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.NhanViens.SingleOrDefault(p => p.Email.Equals(Email));
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
        public NhanVien LayNhanVienTheoMa(int MaNV)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var nhanvien = db.NhanViens.SingleOrDefault(c => c.MaNV == MaNV);
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
