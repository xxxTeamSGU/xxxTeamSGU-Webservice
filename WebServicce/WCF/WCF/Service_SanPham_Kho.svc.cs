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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_SanPham_Kho" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_SanPham_Kho.svc or Service_SanPham_Kho.svc.cs at the Solution Explorer and start debugging.
    public class Service_SanPham_Kho : IService_SanPham_Kho
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        [WebMethod]
        public List<Kho> LayTatCa()
        {
            try
            {
                //Gọi tới Database
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //string query = "select * from Kho k, SanPham sp where k.MaSP=sp.MaSP";
                    //Chọn tất cả trong bảng sản phẩm trong CSDL
                    var list = (db.Khoes.Select(p => p).ToList());
                    //Xuất ra dang sách sản phẩm
                    //var list = query.Select(p => p).ToList();
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
        public List<SanPham_Price> LayKhoTheoSP(int MaSP, int MaMau)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Where(n => n.MaSP == MaSP && n.MaMau == MaMau).Distinct().Select(p => new SanPham_Price
                    {
                        _MaSP = p.SanPham.MaSP,
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
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
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
                    }).OrderByDescending(p => p._NgayDang).ToList();
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
                    var khuyenmai = db.Khoes.Where(p=> p.SanPham.MaKM != 1 && p.SanPham.KhuyenMai.NgayKT >= DateTime.Now ).Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
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
        [WebMethod]
        public List<SanPham_Price> DanhMuc(string th, int maloai)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var dm = db.Khoes.Where(n => n.SanPham.ThuongHieu == th && n.SanPham.MaLoai == maloai).Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
                    }).OrderBy(p => p._MaSP).ToList();
                    int index = 0;
                    while (index < dm.Count - 1)
                    {
                        if (dm[index]._MaSP == dm[index + 1]._MaSP)
                            dm.RemoveAt(index);
                        else
                            index++;
                    }
                    return dm;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }

        //Phương thức tìm kiếm sản phẩm
        [WebMethod]
        public List<SanPham_Price> TimKiemSanPham(string Tim)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //Tìm theo tên hoặc thươc hiệu và lấy ra list
                    var listtk = db.Khoes.Where(c => c.SanPham.TenSP.Contains(Tim) || c.SanPham.ThuongHieu.Contains(Tim)).Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _MaMau = p.MaMau,
                        _TenSP = p.SanPham.TenSP,
                        _TenMau = p.Mau.TenMau,
                        _Size = p.Size.Size1,
                        _GiaSP = (decimal)p.GiaBan,
                        _HinhAnh = p.SanPham.HinhAnh,
                        _NgayDang = (DateTime)p.SanPham.NgayDang,
                    }).OrderBy(p => p._MaSP).ToList();
                    int index = 0;
                    while (index < listtk.Count - 1)
                    {
                        if (listtk[index]._MaSP == listtk[index + 1]._MaSP)
                            listtk.RemoveAt(index);
                        else
                            index++;
                    }
                    return listtk;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }
        [WebMethod]
        public List<SanPham_Price> LayTatCaSP()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _TenMau = p.Mau.TenMau,
                        _Size = (int)p.Size.Size1,
                        _GiaSP = (decimal)p.GiaNhap,
                        _GiaBan = (decimal)p.GiaBan,
                    }).OrderBy(p => p._MaSP).ToList();

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
        public List<SanPham_Price> TimSanPham(string TenSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Select(p => new SanPham_Price
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _TenMau = p.Mau.TenMau,
                        _Size = (int)p.Size.Size1,
                        _GiaSP = (decimal)p.GiaNhap,
                        _GiaBan = (decimal)p.GiaBan,
                    }).OrderBy(p => p._MaSP).Where(p => p._TenSP.Contains(TenSP)).ToList();

                    return list;
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
