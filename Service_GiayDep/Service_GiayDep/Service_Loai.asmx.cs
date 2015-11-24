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
    /// Summary description for Service_Loai
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Loai : IService_Loai
    {

        [WebMethod]
        public List<Loai> LayTatCaLoai()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Loais.Select(p => p).ToList();
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
        public bool ThemLoai(string l)
        {
            Loai loai = new Loai();
            loai.TenLoai = l;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.Loais.Add(loai);
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
        public bool SuaLoai(int MaLoai, string TenLoai)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Loais.Single(p => p.MaLoai == MaLoai);
                    if (item != null)
                    {
                        item.TenLoai = TenLoai;
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
        public bool XoaLoai(int MaLoai)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.Loais.SingleOrDefault(p => p.MaLoai == MaLoai);
                    if (SpDelete != null)
                    {
                        db.Loais.Remove(SpDelete);
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
        public bool CheckLoai(string TenLoai)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.Loais.SingleOrDefault(p => p.TenLoai.Equals(TenLoai));
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
