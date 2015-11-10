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
    /// Summary description for Service_KhuyenMai
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_KhuyenMai : IService_KM
    {
        [WebMethod]
        public List<KhuyenMai> LayTatCaKM()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.KhuyenMais.Select(p => p).ToList();
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
        public bool ThemKM(string TenKM, DateTime NgayBD, DateTime NgayKT)
        {
            KhuyenMai km = new KhuyenMai();
            km.TenKM = TenKM;
            km.NgayBD = NgayBD;
            km.NgayKT = NgayKT;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.KhuyenMais.Add(km);
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
        public bool SuaKM(int MaKM, string TenKM, DateTime NgayBD, DateTime NgayKT)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.KhuyenMais.Single(p => p.MaKM == MaKM);
                    if (item != null)
                    {
                        item.TenKM = TenKM;
                        item.NgayBD = NgayBD;
                        item.NgayKT = NgayKT;
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
        public bool XoaKM(int MaKM)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.KhuyenMais.SingleOrDefault(p => p.MaKM == MaKM);
                    if (SpDelete != null)
                    {
                        db.KhuyenMais.Remove(SpDelete);
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
