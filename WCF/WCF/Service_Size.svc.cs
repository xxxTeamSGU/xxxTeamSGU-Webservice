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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Size" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Size.svc or Service_Size.svc.cs at the Solution Explorer and start debugging.
    public class Service_Size : IService_Size
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        //Lấy size theo mã màu
        [WebMethod]
        public List<Size> LayTatCaSize()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Sizes.Select(p => p).ToList();
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
        public bool ThemSize(int TenSize)
        {
            Size s = new Size();
            s.Size1 = TenSize;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.Sizes.Add(s);
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
        public bool SuaSize(int MaSize, int TenSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Sizes.SingleOrDefault(p => p.MaSize == MaSize);
                    if (item != null)
                    {
                        item.Size1 = TenSize;
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
        public bool XoaSize(int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var SpDelete = db.Sizes.SingleOrDefault(p => p.MaSize == MaSize);
                    if (SpDelete != null)
                    {
                        db.Sizes.Remove(SpDelete);
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
        public Size LaySizeTheoMa(int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    Size tensize = db.Sizes.SingleOrDefault(n => n.MaSize == MaSize);
                    return tensize;
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
