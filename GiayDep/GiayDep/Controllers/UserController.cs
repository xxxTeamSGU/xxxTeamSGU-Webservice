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
        Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
        Service_KhachHang.Service_KhachHang kh = new Service_KhachHang.Service_KhachHang();
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
        public ActionResult Register(string HoTen, DateTime NgaySinh, string Email, string MatKhau, string SDT, string DiaChi, string GioiTinh, DateTime NgayDangKi)
        {
            if (ModelState.IsValid)
            {


                var them = kh.ThemKhachHang(HoTen,NgaySinh, Email, MatKhau, SDT, DiaChi, GioiTinh, NgayDangKi);
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
        public ActionResult Login(FormCollection f)
        {
            String s_email = f["email"].ToString();
            String s_password = f["password"].ToString();
            //KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.email == s_email && n.password == s_password);
            var khachhang = kh.Login(s_email,s_password);
            if (khachhang != null)
            {
                ViewBag.Thongbao = "Chúc mừng bạn đã đăng nhập thành công !";
                Session["khachhang"] = khachhang;
                return RedirectToAction("Index", "Home");

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
	}
}