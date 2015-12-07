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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Loai" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Loai.svc or Service_Loai.svc.cs at the Solution Explorer and start debugging.
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
        public bool ThemLoai(string TenLoai)
        {
            Loai loai = new Loai();
            loai.TenLoai = TenLoai;
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
