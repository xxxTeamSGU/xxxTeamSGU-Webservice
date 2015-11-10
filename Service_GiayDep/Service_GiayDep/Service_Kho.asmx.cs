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
    /// Summary description for Service_Kho
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Kho : IService_Kho
    {
        [WebMethod]
        public List<SanPham_Price> LayKhoTheoSP(int MaSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Where(p => p.MaSP == MaSP).Select(p => new SanPham_Price {_MaSP = p.MaSP, _TenSP = p.SanPham.TenSP, _MaMau= p.MaMau, _MaSize = p.MaSize , _GiaSP = (decimal)p.GiaBan }).ToList();
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
        public bool NhapMoi(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap)
        {
            Kho kho = new Kho();
            kho.MaSP = MaSP;
            kho.MaMau = Mau;
            kho.MaSize = MaSize;
            kho.SL = Soluong;
            kho.GiaNhap = GiaNhap;
            kho.GiaBan = 0;
            try
            {
                using(DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.Khoes.Add(kho);
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
        public bool CapNhat(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap)
        {
            try
            {
                using(DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
                        item.SL = item.SL + Soluong;
                        item.GiaNhap = GiaNhap;
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
        public bool CheckKho(int MaSP, int Mau, int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
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
        public bool ThemKho(int MaHDN)
        {
            try
            {
                bool check = true;
                using(DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.CTHDNs.Where(p => p.MaHDN == MaHDN).Select(p => p).ToList();
                    for (int i=0 ; i< list.Count; i++)
                    {
                        if (CheckKho(list[i].MaSP,list[i].MaMau,list[i].MaSize))
                        {
                            decimal GiaNhap = (decimal)list[i].GiaNhap;
                            int MaSP = list[i].MaSP;
                            int MaMau = list[i].MaMau;
                            int MaSize = list[i].MaSize;
                            int SoLuong = (int)list[i].SL;

                            check = CapNhat(MaSP, MaMau, MaSize, SoLuong, GiaNhap);
                            if (check == false)
                                break;
                        }
                        else
                        {

                            decimal GiaNhap = (decimal)list[i].GiaNhap;
                            int MaSP = list[i].MaSP;
                            int MaMau = list[i].MaMau;
                            int MaSize = list[i].MaSize;
                            int SoLuong = (int)list[i].SL;

                            check = NhapMoi(MaSP, MaMau, MaSize, SoLuong, GiaNhap);
                            if (check == false)
                                break;

                        }
            
                    }
                    if (check == true)
                    {
                        Service_HoaDonNhap sv = new Service_HoaDonNhap();
                        check = sv.DuyetHD(MaHDN);
                    }
                    return check;
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
