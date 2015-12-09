using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using PagedList;
using PagedList.Mvc;

namespace GiayDep.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        Service_Kho.Service_KhoClient k = new Service_Kho.Service_KhoClient();
        Service_SanPham_Kho.Service_SanPham_KhoClient spk = new Service_SanPham_Kho.Service_SanPham_KhoClient();
        public PartialViewResult SanphammoiPartial()
        {
            var listsanphammoi = spk.SanphammoiPartial().Distinct().Take(6).ToList();
            return PartialView(listsanphammoi);

        }
       

        public PartialViewResult SanphamkhuyenmaiPartial()
        {
            var listkhuyenmai = spk.SanphamkhuyenmaiPartial().Distinct().Take(6).ToList();
            return PartialView(listkhuyenmai);
        }
        
        public ViewResult Chitietsanpham(int MaSP, int MaMau)
        {
            var chitiet = spk.LayKhoTheoSP(MaSP, MaMau).ToList();
            ViewBag.GiaBan = GiaBan(MaSP,MaMau);
            return View(chitiet);
        }
        public ViewResult Muangay(int MaSP, int MaMau)
        {
            var chitiet = spk.LayKhoTheoSP(MaSP, MaMau).ToList();
            ViewBag.GiaBan = GiaBan(MaSP, MaMau);
            return View(chitiet);
        }
        public PartialViewResult mau(int masp)
        {
            var listmau = k.LayMau(masp).ToList();
            
            return PartialView(listmau);
        }

        public PartialViewResult size(int masp, int mamau)
        {
            var listmau = k.LaySize(masp,mamau).ToList();
            return PartialView(listmau);
        }
        public ActionResult LayMau(int MaSP, int MaMau)
        {
            var laymau = k.ChonMau(MaSP,MaMau);
            return View(laymau);
        }
        private decimal GiaBan(int MaSP, int MaMau)
        {
            var giaban = k.LayGia(MaSP,MaMau);
            return giaban;
        }
        public ActionResult images()
        {
            return View();
        }
	}
}