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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_KhuyenMai" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_KhuyenMai.svc or Service_KhuyenMai.svc.cs at the Solution Explorer and start debugging.
    public class Service_KhuyenMai : IService_KhuyenMai
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
        [WebMethod]
        public bool CheckKhuyenMai(string TenKM)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.KhuyenMais.SingleOrDefault(p => p.TenKM.Equals(TenKM));
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
