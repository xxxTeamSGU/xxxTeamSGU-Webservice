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
    /// Summary description for IService_HDNhap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
 
        public class Service_HoaDonNhap : IService_HoaDonNhap
        {

            [WebMethod]
            public List<HDNhap> LayTatCaHoaDon()
            {
                try
                {
                    using (DBGiayDepEntities db = new DBGiayDepEntities())
                    {
                        var list = db.HDNhaps.Select(p => p).ToList();
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


        }
    }
