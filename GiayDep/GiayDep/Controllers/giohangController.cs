using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using GiayDep.Service_KhachHang;
using GiayDep.Service_DonHang;

namespace GiayDep.Controllers
{
    public class giohangController : Controller
    {
        //
        // GET: /giohang/
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        Service_SanPham_Kho.Service_SanPham_KhoClient k = new Service_SanPham_Kho.Service_SanPham_KhoClient();
        Service_DonHang.Service_DonHangClient dh = new Service_DonHang.Service_DonHangClient();
        Service_KhachHang.Service_KhachHangClient khachhang = new Service_KhachHang.Service_KhachHangClient();
        Service_CTDH.Service_CTDHClient ctdh = new Service_CTDH.Service_CTDHClient();

        #region Giỏ Hàng
        //Lấy giỏ hàng
        public List<giohang> laygiohang()
      {
          List<giohang> listgiohang = Session["giohang"] as List<giohang>;
          if(listgiohang==null)
          {
              //Thêm liat giỏ hàng mới.
              listgiohang= new List<giohang>();
              //Tạo session lưu list giỏ hàng.
              Session["giohang"] = listgiohang;

          }
          return listgiohang;
      }
        [HttpPost]
      public ActionResult themgiohang(int imasp,int mamau,int size, string strUrl)
      {
          var sp = k.LayKhoTheoSP(imasp,mamau);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          //lấy ra session
          List<giohang> listgiohang = laygiohang();
          //ktra tồn tại trong giỏ hàng chưa
          giohang gh = listgiohang.Find(n => n.imasp == imasp && n.imamau==mamau && n.isize ==size);
          if (gh == null)
          {
              gh = new giohang(imasp, mamau, size);
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
      public ActionResult capnhatgiohang(int imasp,int mamau,int size, FormCollection f)
      {
          var sp = k.LayKhoTheoSP(imasp, mamau);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          List<giohang> listgiohang = laygiohang();
          giohang gh = listgiohang.SingleOrDefault(n => n.imasp == imasp && n.imamau ==mamau && n.isize==size );
          if (gh != null)
          {
              gh.soluong = int.Parse(f["txtSoluong"].ToString());

          }
          return RedirectToAction("giohang");
      }

      public ActionResult xoagiohang(int imasp, int mamau, int size)
      {
          var sp = k.LayKhoTheoSP(imasp, mamau);
          if (sp == null)
          {
              Response.StatusCode = 404;
              return null;
          }
          List<giohang> listgiohang = laygiohang();
          giohang gh = listgiohang.SingleOrDefault(n => n.imasp == imasp && n.imamau== mamau && n.isize== size);
          if (gh != null)
          {
              listgiohang.RemoveAll(n => n.imasp == imasp && n.imamau==mamau && n.isize == size);
          }
          if (listgiohang.Count == 0)
          {
              return RedirectToAction("Index", "Home");
          }
          return RedirectToAction("giohang");
      }
      public ActionResult giohang()
      {
          if (Session["giohang"] == null)
          {
              return RedirectToAction("Index", "Home");
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
      private decimal Tongtien()
      {

          decimal iTongtien = 0;
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
      public ActionResult addslpartial(int imasp, int mamau, string strUrl)
      {
          var sp = k.LayKhoTheoSP(imasp, mamau);
          List<giohang> listgiohang = laygiohang();
          //ktra tồn tại trong giỏ hàng chưa
          giohang gh = listgiohang.Find(n => n.imasp == imasp);
          ViewBag.addsl = gh.soluong++;
          return View();
      }
        #endregion
      #region Đơn hàng
      public ActionResult DonHang()
      {
          if (Session["khachhang"] == null || Session["khachhang"] == "")
          {
              return RedirectToAction("Login", "User");
          }
          if (Session["giohang"] == null)
          {
              return RedirectToAction("Index", "Home");
          }
          List<giohang> listgiohang = laygiohang();
          ViewBag.Tongtien = Tongtien();
          var pp = Session["giohang"] as List<giohang>;
          return View(pp);
      }
        #endregion
        //Xây đựng chức năng đặt hàng
        #region Đặt Hàng 
        [HttpPost]
      public ActionResult DatHang()
      {
            //kiểm tra người dùng có hay không
            if(Session["khachhang"] == null || Session["khachhang"] == "" )
            {
                return RedirectToAction("Login", "User");
            }
            if(Session["giohang"]==null)
            {
                return RedirectToAction("Index", "Home");
            }

            //Thêm đơn hàng
            GiayDep.Service_KhachHang.KhachHang kh = (GiayDep.Service_KhachHang.KhachHang)Session["khachhang"];
            int themdh = dh.ThemDH( kh.MaKH, DateTime.Now,(decimal)Tongtien(),0,null);
            
            ////Them chi tiet don hang
            List<giohang> gh = laygiohang();
            foreach (var item in gh)
            {
                var ctdhnew = ctdh.ThemCTDH(themdh,item.imasp, item.imamau, item.isize, item.soluong, item.thanhtien);
            }
            Session["giohang"]=null;
            return RedirectToAction("ThongBaoDH", "giohang");
          //return View(gh);
      }
      #endregion
        #region Thông báo đơn hàng
         public ActionResult ThongBaoDH()
        {
            ViewBag.tb = "Bạn đã đặt hàng thành công. Chúng tôi sẽ giao hàng trong thời gian sớm nhất 2-3 ngày làm việc.";
            return View();
        }
        #endregion 

      
    }
}