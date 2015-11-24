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
    /// Summary description for Service_SanPham_Kho
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_SanPham_Kho : IService_SanPham_Kho
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        [WebMethod]
        public List<SanPham_Price> LayKhoTheoSP(int MaSP, int MaMau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Where(n=>n.MaSP==MaSP && n.MaMau==MaMau).Distinct().Select(p => new SanPham_Price
                    {
                        _MaSP = p.SanPham.MaSP,
                        _MaMau = p.Mau.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh

                    }).OrderBy(p => p._MaSP).ToList();
                    int index = 0;
                    while (index < list.Count - 1)
                    {
                        if (list[index]._MaSP == list[index + 1]._MaSP)
                            list.RemoveAt(index);
                        else
                            index++;
                    }
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
        public List<SanPham_Price> SanphammoiPartial()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                    }).OrderBy(p => p._MaSP).ToList();
                    int index = 0;
                    while (index < list.Count - 1)
                    {
                        if (list[index]._MaSP == list[index + 1]._MaSP)
                            list.RemoveAt(index);
                        else
                            index++;
                    }
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
        public List<SanPham_Price> SanphamkhuyenmaiPartial()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var khuyenmai = db.Khoes.Select(p => new SanPham_Price   {
                        _MaSP = p.MaSP,
                        _MaMau = p.Mau.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh
                        
                    }).OrderBy(p => p._MaSP).ToList();
                    int index = 0;
                    while (index < khuyenmai.Count - 1)
                    {
                        if (khuyenmai[index]._MaSP == khuyenmai[index + 1]._MaSP)
                            khuyenmai.RemoveAt(index);
                        else
                            index++;
                    }
                    return khuyenmai;
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
