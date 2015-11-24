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
    /// Summary description for Service_SanPham
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_SanPham : IService_SanPham
    {
        //Connect tới Database Entity
        DBGiayDepEntities db = new DBGiayDepEntities();
        //Tạo phương thức trong webrvice
        [WebMethod]
        public List<SanPham> LayTatCaSanPham()
        {
            try
            {
                //Gọi tới Database
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //string query = "select * from Kho k, SanPham sp where k.MaSP=sp.MaSP";
                    //Chọn tất cả trong bảng sản phẩm trong CSDL
                    var list = (db.SanPhams.Select(p => p).ToList());
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
        //Phương thức thêm 1 sản phẩm mới
        [WebMethod]
        public bool ThemSanPham(string TenSP,int MaLoai,string ThuongHieu,
            string HinhAnh, string MoTa,int MaKM,DateTime NgayDang, string MoTaCT)
        {
            SanPham sanpham = new SanPham();
            sanpham.TenSP = TenSP;
            sanpham.MaLoai = (int)MaLoai;
            sanpham.ThuongHieu = ThuongHieu;
            sanpham.HinhAnh = HinhAnh;
            sanpham.MoTa = MoTa;
            sanpham.MaKM = (int)MaKM;
            sanpham.NgayDang = NgayDang;
            sanpham.MoTaCT = MoTaCT;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //Lưu add sản phẩm mới vào model
                    db.SanPhams.Add(sanpham);
                    //Lưu vào CSDL
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
        //Phương thức sửa sản phẩm
        [WebMethod]
        public bool SuaSanPham(int MaSP, string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT)
        {
           
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                { 
                    //Tìm MaSP trong bảng SanPham trong DB
                    var item = db.SanPhams.Single(p => p.MaSP == MaSP);
                    //Nếu có thì lấy các thông tin ra để sửa
                    if (item != null)
                    {
                        item.TenSP = TenSP;
                        item.MaLoai = (int)MaLoai;
                        item.ThuongHieu = ThuongHieu;
                        item.HinhAnh = HinhAnh;
                        item.MoTa = MoTa;
                        item.MaKM = (int)MaKM;
                        item.NgayDang= NgayDang;
                        item.MoTaCT=MoTaCT;

                        db.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        //Phương thức xóa sản phẩm
        [WebMethod]
        public bool XoaSanPham(int MaSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                { 
                    //Tìm MaSP muốn xóa
                    var SpDelete = db.SanPhams.SingleOrDefault(p =>p.MaSP == MaSP);
                    //Nếu có
                    if(SpDelete!=null)
                    {
                        //Thực hiện xóa sản phẩm
                        db.SanPhams.Remove(SpDelete);
                        //lưu lại thay đổi
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
        //Phương thức tìm kiếm sản phẩm
        [WebMethod]
        public List<SanPham> TimKiemSanPham(string Tim)
        {
            try
            {
                using(DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //Tìm theo tên hoặc thươc hiệu và lấy ra list
                    var list = db.SanPhams.Where( c => c.TenSP.Contains(Tim) || c.ThuongHieu.Contains(Tim)).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        //Phương thức lấy ra sản phẩm mới theo ngày
        
 
       

        //Phương thức lấy chi tiết sản phẩm
        //public SanPham Chitietsanpham(int masp)
        //{
        //    try
        //    {
               
        //        SanPham chitiet = db.SanPhams.SingleOrDefault(n => n.MaSP == masp);
         
                              //join k in db.Khoes
                              //on sp.MaSP equals k.MaSP
                              //where sp.MaSP == masp && k.MaSize==1 && k.MaMau==3
                              
                              //{
                                 
                                 //masp=sp.MaSP,
                                 //tensp = sp.TenSP,
                                 //hinhanh = sp.HinhAnh,
                                 //giaban= (decimal)k.GiaBan
                             // });
                //SPK sp = chitiet.ToList();
                //return chitiet;
                //}
        [WebMethod]
        public SanPham LayMa(int masp)
        {
            SanPham list = db.SanPhams.SingleOrDefault(n => n.MaSP==masp);
            return list;


        }
        [WebMethod]
        public List<TH> ThuongHieuNam()
        {
            List<TH> list = db.SanPhams.Where(n=>n.MaLoai==1).Select(n => new TH
            {
                _ThuongHieu = n.ThuongHieu,
            }).Distinct().ToList();
            return list;
        }
        [WebMethod]
        public List<TH> ThuongHieuNu()
        {
            List<TH> list = db.SanPhams.Where(n => n.MaLoai == 2).Select(n => new TH
            {
                _ThuongHieu = n.ThuongHieu,
            }).Distinct().ToList();
            return list;
        }
        [WebMethod]
        public List<TH> ThuongHieuTreEm()
        {
            List<TH> list = db.SanPhams.Where(n => n.MaLoai == 3).Select(n => new TH
            {
                _ThuongHieu = n.ThuongHieu,
            }).Distinct().ToList();
            return list;
        }
    }
}
