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
    /// Summary description for Service_CTHDN
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_CTHDN : IService_CTHDN
    {

         [WebMethod]
        public List<CTHDN> LayCTHDN(int MaHDN)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.CTHDNs.Where(p => p.MaHDN == MaHDN).ToList();
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
        public bool ThemCTHDN(int MaHDN, int MaSP,int MaMau,int MaSize, int SoLuong, decimal DonGia)
        {
            CTHDN CT = new CTHDN();
            CT.MaHDN = MaHDN;
            CT.MaSP = MaSP;
            CT.MaMau = MaMau;
            CT.MaSize = MaSize;
            CT.SL = SoLuong;
            CT.GiaNhap = (decimal)DonGia;

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.CTHDNs.Add(CT);
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
        public bool SuaCTHDN(int MaHDN, int MaSP,int MaMau,int MaSize, int SoLuong, decimal DonGia)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.CTHDNs.Single(p => p.MaHDN == MaHDN && p.MaSP == MaSP);
                    if (item != null)
                    {
                        item.MaMau = MaMau;
                        item.MaSize = MaSize;
                        item.SL= SoLuong;
                        item.GiaNhap = (decimal)DonGia;
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
        public bool XoaCTHDN(int MaHDN, int MaSP, int MaMau,int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.CTHDNs.SingleOrDefault(p => p.MaHDN == MaHDN && p.MaSP == MaSP && p.MaSize == MaSize && p.MaMau == MaMau);
                    if (SpDelete != null)
                    {
                        db.CTHDNs.Remove(SpDelete);
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
