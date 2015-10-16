using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;

namespace GiayDep.Controllers
{
    public class giohangController : Controller
    {
        //
        // GET: /giohang/
        Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
      public List<giohang> laygiohang()
      {
          List<giohang> listgiohang = Session["giohang"] as List<giohang>;
          if(listgiohang==null)
          {
              listgiohang= new List<giohang>();
              Session["giohang"] = listgiohang;

          }
          return listgiohang;
      }
      public ActionResult themgiohang(int imasp, string strUrl)
      {
          var sp = db.LaySanPham(imasp);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          //lấy ra session
          List<giohang> listgiohang = laygiohang();
          //ktra tồn tại trong giỏ hàng chưa
          giohang gh = listgiohang.Find(n => n.imasp == imasp);
          if (gh == null)
          {
              gh = new giohang(imasp);
              listgiohang.Add(gh);
              ViewBag.Tb = " Đã thêm thành công vào giỏ hàng.";
              return Redirect(strUrl);
          }
          else
          {
              gh.soluong++;
              return Redirect(strUrl);
          }
      }
      public ActionResult capnhatgiohang(int imasp, FormCollection f)
      {
          var sp = db.LaySanPham(imasp);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          List<giohang> listgiohang = laygiohang();
          giohang gh = listgiohang.SingleOrDefault(n => n.imasp == imasp);
          if (gh != null)
          {
              gh.soluong = int.Parse(f["txtSoluong"].ToString());

          }
          return View("giohang");
      }

      public ActionResult xoagiohang(int imasp)
      {
          var sp = db.LaySanPham(imasp);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          List<giohang> listgiohang = laygiohang();
          giohang gh = listgiohang.SingleOrDefault(n => n.imasp == imasp);
          if (gh != null)
          {
              listgiohang.RemoveAll(n => n.imasp == imasp);
          }
          if (listgiohang.Count == 0)
          {
              RedirectToAction("Home", "Index");
          }
          return RedirectToAction("giohang");
      }
      public ActionResult giohang()
      {
          if (Session["giohang"] == null)
          {
              RedirectToAction("Home", "Index");
          }
          List<giohang> listgiohang = laygiohang();

          return View(listgiohang);
      }
      private int Tongsoluong()
      {
          int iTongsoluong = 0;
          List<giohang> listgiohang = Session["giohang"] as List<giohang>;
          if (listgiohang != null)
          {
              iTongsoluong = listgiohang.Sum(n => n.soluong);

          }
          return iTongsoluong;
      }
      private double Tongtien()
      {

          double iTongtien = 0;
          List<giohang> listgiohang = Session["giohang"] as List<giohang>;
          if (listgiohang != null)
          {
              iTongtien = listgiohang.Sum(n => n.thanhtien);
          }
          return iTongtien;
      }
      public ActionResult giohangpartial()
      {
          if (Tongsoluong() == 0)
          {
              return PartialView();
          }
          ViewBag.Tongsoluong = Tongsoluong();
          ViewBag.Tongtien = Tongtien();
          return PartialView();
      }
      public ActionResult addslpartial(int imasp, string strUrl)
      {
          var sp = db.LaySanPham(imasp);
          List<giohang> listgiohang = laygiohang();
          //ktra tồn tại trong giỏ hàng chưa
          giohang gh = listgiohang.Find(n => n.imasp == imasp);
          ViewBag.addsl = gh.soluong++;
          return View();
      }
	}
}