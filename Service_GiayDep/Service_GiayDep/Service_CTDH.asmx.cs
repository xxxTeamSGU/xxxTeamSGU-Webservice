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
    /// Summary description for Service_CTDH
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_CTDH : IService_CTDH
    {

        [WebMethod]
        public bool ThemCTHDH(int MaDH, int MaSP, int MaMau, int MaSize, int SoLuong, decimal DonGia)
        {
            CTDH ctdh = new CTDH();
            ctdh.MaDH = MaDH;
            ctdh.MaSP = MaSP;
            ctdh.MaMau = MaMau;
            ctdh.MaSize = MaSize;
            ctdh.SL = SoLuong;
            ctdh.DonGia = (decimal)DonGia;

            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.CTDHs.Add(ctdh);
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
    }
}
