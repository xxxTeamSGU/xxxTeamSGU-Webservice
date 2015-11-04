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
        public ActionResult Register(string HoTen, string SDT, string Email, string MatKhau, string NgaySinh, string DiaChi, int GioiTinh)
        {
                var khachhang = kh.ThemKhachHang(HoTen,SDT,Email,MatKhau,NgaySinh,DiaChi,GioiTinh);
                return RedirectToAction("Index", "Home");
  

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
            var khachhang = kh.Login(s_email, s_password);
            if (khachhang != null)
            {
                //ViewBag.Thongbao = "Chúc mừng bạn đã đăng nhập thành công !";
                Session["khachhang"] = khachhang;
                return RedirectToAction("Index", "Home");

            }
            ViewBag.Thongbao = "Email hoặc mật khẩu không đúng !";
            return RedirectToAction("Login", "User");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult LoginPartial()
        {
           
            return PartialView();
        }
	}
}