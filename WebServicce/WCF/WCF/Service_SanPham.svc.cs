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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService_SanPham
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
                    //Chọn tất cả trong bảng sản phẩm trong CSDL
                    var list = (db.SanPhams.Where(p => p.TrangThai == 1).ToList());
                    //Xuất ra dang sách sản phẩm
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
        public bool ThemSanPham(string TenSP, int MaLoai, string ThuongHieu,
            string HinhAnh, string MoTa, int MaKM, DateTime NgayDang, string MoTaCT)
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
                        item.NgayDang = NgayDang;
                        item.MoTaCT = MoTaCT;

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
                    var SpDelete = db.SanPhams.SingleOrDefault(p => p.MaSP == MaSP);
                    if (SpDelete != null)
                    {
                        SpDelete.TrangThai = 0;
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
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    //Tìm theo tên hoặc thươc hiệu và lấy ra list
                    var list = db.SanPhams.Where(c => c.TenSP.Contains(Tim) || c.ThuongHieu.Contains(Tim)).ToList();
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
        [WebMethod]
        public List<SanPham> SanphammoiPartial()
        {
            var listSanphammoi = db.SanPhams.Take(6).ToList();
            return listSanphammoi;
        }
        //Phương thức lấy sản phẩm khuyến mãi khi thuộc tính KM =1
        [WebMethod]
        public List<SanPham> SanphamkhuyenmaiPartial()
        {
            var listSanphammoi = db.SanPhams.Where(n => n.MaKM == 1).Take(6).ToList();
            return listSanphammoi;
        }
        [WebMethod]
        //Phương thức lấy chi tiết sản phẩm
        public SanPham Chitietsanpham(int masp)
        {
            try
            {
                SanPham chitiet = db.SanPhams.SingleOrDefault(n => n.MaSP == masp);

                return chitiet;
            }
            catch
            {
                return null;
            }
        }
        [WebMethod]
        public SanPham LaySanPham(int imasp)
        {
            SanPham laymasp = db.SanPhams.SingleOrDefault(n => n.MaSP == imasp);
            return laymasp;
        }
        [WebMethod]
        public bool CheckSanPham(string TenSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var check = db.SanPhams.SingleOrDefault(p => p.TenSP.Equals(TenSP));
                    if (check != null)
                        return true;
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
        public SanPham LayMa(int masp)
        {
            SanPham list = db.SanPhams.SingleOrDefault(n => n.MaSP == masp);
            return list;


        }
        [WebMethod]
        public List<TH> ThuongHieuNam()
        {
            List<TH> list = db.SanPhams.Where(n => n.MaLoai == 1).Select(n => new TH
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
