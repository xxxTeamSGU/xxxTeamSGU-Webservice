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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_NhaCungCap" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_NhaCungCap.svc or Service_NhaCungCap.svc.cs at the Solution Explorer and start debugging.
    public class Service_NhaCungCap : IService_NhaCungCap
    {
        [WebMethod]
        public List<NhaCungCap> LayTatCaNhaCungCap()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.NhaCungCaps.Select(p => p).ToList();
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
        public bool ThemNhaCungCap(string TenNCC, string DiaChi, string SDT, string SoTK)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.TenNCC = TenNCC;
            ncc.DiaChi = DiaChi;
            ncc.SDT = SDT;
            ncc.SoTK = SoTK;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.NhaCungCaps.Add(ncc);
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
        public bool SuaNhaCungCap(int MaNCC, string TenNCC, string DiaChi, string SDT, string SoTK)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.NhaCungCaps.Single(p => p.MaNCC == MaNCC);
                    if (item != null)
                    {
                        if (!TenNCC.Equals(""))
                        {
                            item.TenNCC = TenNCC;
                        }
                        if (!DiaChi.Equals(""))
                        {
                            item.DiaChi = DiaChi;
                        }
                        if (!SDT.Equals(""))
                        {
                            item.SDT = SDT;
                        }
                        if (!SoTK.Equals(""))
                        {
                            item.SoTK = SoTK;
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
        public bool XoaNhaCungCap(int MaNCC)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.NhaCungCaps.SingleOrDefault(p => p.MaNCC == MaNCC);
                    if (SpDelete != null)
                    {
                        db.NhaCungCaps.Remove(SpDelete);
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
        public List<NhaCungCap> TimKiemNhaCungCap(string x)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.NhaCungCaps.Where(c => c.TenNCC.Contains(x) || c.DiaChi.Contains(x) || c.SDT.Contains(x) || c.SoTK.Contains(x)).ToList();
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
        public bool CheckNhaCungCap(string NCC)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.NhaCungCaps.SingleOrDefault(p => p.TenNCC.Equals(NCC));
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
    }
}
