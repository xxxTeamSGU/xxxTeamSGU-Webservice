﻿using System;
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
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Register(KhachHang kh)
        //{
        //    if (ModelState.IsValid)
        //    {


        //        db.KhachHangs.Add(kh);
        //        db.SaveChanges();
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(kh);
            
        //}
        //[HttpGet]
        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login(FormCollection f)
        //{
        //    String s_email = f["email"].ToString();
        //    String s_password = f["password"].ToString();
        //    //KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.email == s_email && n.password == s_password);
        //  //  if(kh != null)
        //   // {
        //   //     ViewBag.Thongbao = "Chúc mừng bạn đã đăng nhập thành công !";
        //  //      Session["email"] = kh;
        //  //      return View();
                
        //  //  }
        //  //  ViewBag.Thongbao = "Email hoặc mật khẩu không đúng !";
        //    return View();
        //}
	}
}