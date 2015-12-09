using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using System.Data.Entity;
using System.Data;


namespace GiayDep.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        Service_DonHang.Service_DonHangClient dh = new Service_DonHang.Service_DonHangClient();
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        Service_KhachHang.Service_KhachHangClient kh = new Service_KhachHang.Service_KhachHangClient();
        Service_CTDH.Service_CTDHClient ctdh = new Service_CTDH.Service_CTDHClient();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string HoTen, DateTime NgaySinh, string Email, string MatKhau, string SDT, string DiaChi, string GioiTinh,FormCollection f)
        {
            if (ModelState.IsValid)
            {
                var checkemail = kh.CheckEmail(Email);
                if (checkemail == true)
                {
                    ViewBag.emailfalse = "(*)Email này đã đăng kí.";
                    return View();
                }
                var them = kh.ThemKhachHang(HoTen, NgaySinh, Email, MatKhau, SDT, DiaChi, GioiTinh);
                return RedirectToAction("Index", "Home");
            }
            return View(kh);

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string strUrl, FormCollection f)
        {
            String s_email = f["email"].ToString();
            String s_password = f["password"].ToString();
            //KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.email == s_email && n.password == s_password);
            var khachhang = kh.Login(s_email,s_password);
            if (khachhang != null)
            {
                if (Session["giohang"] == null)
                {
                    ViewBag.Thongbao = "Chúc mừng bạn đã đăng nhập thành công !";
                    Session["khachhang"] = khachhang;
                    return View();
                }
                Session["khachhang"] = khachhang;
                return RedirectToAction("giohang", "giohang");


            }
            ViewBag.Thongbao = "Email hoặc mật khẩu không đúng !";
            return View();
        }
        public ActionResult Logout ()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public PartialViewResult Name ()
        {
            return PartialView();
        }
        public PartialViewResult Thongtinkhachhang()
        {
            return PartialView();
        }
        #region Lịch sử
        public ActionResult lichsumuahang()
        {
            if (Session["khachhang"] == null || Session["khachhang"] == "")
            {
                return RedirectToAction("Login", "User");
            }
            GiayDep.Service_KhachHang.KhachHang kh = (GiayDep.Service_KhachHang.KhachHang)Session["khachhang"];
            var listls = dh.LichSuDH(kh.MaKH).ToList();
            return View(listls);
        }
        #endregion
        #region Hủy đơn hàng
        public ActionResult huydh(int MaDH, int TinhTrang)
        {
            if (Session["khachhang"] == null || Session["khachhang"] == "")
            {
                return RedirectToAction("Login", "User");
            }
            var listls = dh.SuaDH(MaDH,3);
            return RedirectToAction("lichsumuahang", "User");
        }
        #endregion
        #region Chi tiết đơn hàng
        public ActionResult Chitietdonhang(int MaDH)
        {
            if (Session["khachhang"] == null || Session["khachhang"] == "")
            {
                return RedirectToAction("Login", "User");
            }

            var listct = ctdh.LsCTDH(MaDH).ToList();
            return View(listct);
        }
        #endregion

        #region Load thông tin khách hàng
        [HttpGet]
        public ActionResult SuaKH(int MaKH)
        {
            if (Session["khachhang"] == null || Session["khachhang"] == "")
            {
                return RedirectToAction("Login", "User");
            }
            GiayDep.Service_KhachHang.KhachHang khachhang = (GiayDep.Service_KhachHang.KhachHang)Session["khachhang"];
            var listkh = kh.LayKhachHang(khachhang.MaKH);
            return View(listkh);
        }
        #endregion
        #region Sửa thông tin khách hàng
        [HttpPost]
        public ActionResult SuaKH(int MaKH, string HoTen, DateTime NgaySinh, string Email, string SDT, string DiaChi)
        {

            if (Session["khachhang"] == null || Session["khachhang"] == "")
            {
                return RedirectToAction("Login", "User");
            }
            GiayDep.Service_KhachHang.KhachHang khachhang = (GiayDep.Service_KhachHang.KhachHang)Session["khachhang"];

            var listkh = kh.SuaKhachHang(khachhang.MaKH, HoTen, NgaySinh, Email, SDT, DiaChi);
            if (listkh == true)
            {
                Session.Clear();
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        #endregion
    }
}