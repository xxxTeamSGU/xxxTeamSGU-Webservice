using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Service_GiayDep.Models;
using System.Diagnostics;
using Service_GiayDep.Interface;

namespace Service_GiayDep
{
    /// <summary>
    /// Summary description for Service_Size
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Size : IServive_Size
    {

        DBGiayDepEntities db = new DBGiayDepEntities();
        //Lấy size theo mã màu
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
