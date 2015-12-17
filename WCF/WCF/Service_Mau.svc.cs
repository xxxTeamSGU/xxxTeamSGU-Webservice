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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Mau" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Mau.svc or Service_Mau.svc.cs at the Solution Explorer and start debugging.
    public class Service_Mau : IService_Mau
    {
        [WebMethod]
        public List<Mau> LayTatCaMau()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Maus.Select(p => p).ToList();
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
        public bool ThemMau(string Mau)
        {
            Mau mau = new Mau();
            mau.TenMau = Mau;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.Maus.Add(mau);
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
        public bool SuaMau(int MaMau, string Mau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Maus.Single(p => p.MaMau == MaMau);
                    if (item != null)
                    {
                        item.TenMau = Mau;
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
        public bool XoaMau(int MaMau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.Maus.SingleOrDefault(p => p.MaMau == MaMau);
                    if (SpDelete != null)
                    {
                        db.Maus.Remove(SpDelete);
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

        //Lấy màu theo mã màu
        [WebMethod]
        public Mau LayMauTheoMa(int MaMau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    Mau tenmau = db.Maus.SingleOrDefault(n => n.MaMau == MaMau);
                    return tenmau;
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
