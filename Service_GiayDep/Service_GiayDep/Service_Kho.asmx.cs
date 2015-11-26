using Service_GiayDep.Interface;
using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service_GiayDep
{
    /// <summary>
    /// Summary description for Service_Kho
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Kho : IService_Kho
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        //Phương thức lấy kho sản phẩm
        [WebMethod]
        public Kho LayKho(int masp)
        {
            try
            {
                //Gọi tới Database
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {


                    var list = (db.Khoes.SingleOrDefault(n => n.MaSP == masp));

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
        public List<LaySize> LaySize(int masp, int mamau)
        {
            var laysize = db.Khoes.Where(n => n.MaSP == masp && n.Mau.MaMau==mamau ).Select(n => new LaySize
            {
                _MaSize=n.Size.MaSize,
                //_Size = n.Size.Size1,
            }).ToList();
           
            return laysize;

        }
        [WebMethod]
        public List<LayMau> LayMau(int masp)
        {
            //var laymau = db.Khoes.Distinct().Where(n=>n.MaSP==masp).Select(n => new LayMau
            //{
            //    _TenMau= n.Mau.TenMau,
            //}).ToList();
            List<LayMau> list = db.Khoes.Where(n=>n.MaSP==masp).Select(n => new LayMau
            {
                _MaSP= n.SanPham.MaSP,
                _MaMau = n.MaMau,
                _TenMau = n.Mau.TenMau,
            }).Distinct().ToList();
            return list;
            
                
        }
        [WebMethod]
        public int LayGia(int MaSP, int MaMau)
        {
            List<Kho> laygia = db.Khoes.Where(n => n.MaSP == MaSP && n.MaMau == MaMau).Select(p => p).ToList();
            if (laygia != null)
            {
                if (laygia.Count > 2)
                {
                    for (int i = 0; i < laygia.Count - 2; i++)
                    {
                        for (int j = i + 1; j < laygia.Count -1; j++)
                            if (laygia[i].GiaBan != laygia[j].GiaBan)
                                return 0;
                        return (int)laygia[0].GiaBan;
                    }
                }
                if (laygia.Count ==2)
                {
                    if (laygia[0].GiaBan != laygia[1].GiaBan)
                        return 0;
                    return (int)laygia[0].GiaBan;
                }
                if (laygia.Count == 1)
                    return (int)laygia[0].GiaBan;


            }
            return 0;

        }
        [WebMethod]
        public List<LaySize> ChonMau(int MaSP, int MaMau)
        {
            var chonmau = db.Khoes.Where(n => n.MaSP == MaSP && n.MaMau==MaMau).Select(n => new LaySize
            {
                _MaSize= n.Size.MaSize,
               // _Size = n.Size.Size1,
            }).Distinct().ToList();
            return chonmau;
        }
      
    }
}
