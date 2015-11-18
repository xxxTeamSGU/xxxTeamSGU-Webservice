using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Service_GiayDep.Models;
using Service_GiayDep.Interface;
using System.Diagnostics;

namespace Service_GiayDep
{
    /// <summary>
    /// Summary description for Service_DonHang
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_DonHang : IService_DonHang
    {

        [WebMethod]
        public int ThemDH(int MaDH, int MaKH, DateTime NgayMua, decimal TongTien, int TinhTrang, string NVDuyet)
        {
            DonHang dh = new DonHang();
            dh.MaDH = MaDH;
            dh.MaKH = MaKH;
            dh.NgayMua = (DateTime)NgayMua;
            dh.TongTien = (decimal)TongTien;
            dh.TinhTrang = TinhTrang;
            dh.NVDuyet = NVDuyet;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.DonHangs.Add(dh);
                    db.SaveChanges();
                    return (int)MaDH;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return 0;
            }
        }
    }
}
