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
        public List<KhachHang> TimKiemKhachHang(string HoTen, string SoDT, string SoTK, string Email)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.KhachHangs.Where(c => c.HoTen.Contains(HoTen) && c.Email.Contains(Email) && c.SoDT.Contains(SoDT) && c.SoTK.Contains(SoTK)).ToList();
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
