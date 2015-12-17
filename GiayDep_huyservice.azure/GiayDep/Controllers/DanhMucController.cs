using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using GiayDep.Service_SanPham;
using PagedList.Mvc;
using PagedList;

namespace GiayDep.Controllers
{
    public class DanhMucController : Controller
    {
        //
        // GET: /DanhMuc/
       Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
       Service_SanPham_Kho.Service_SanPham_KhoClient spk = new Service_SanPham_Kho.Service_SanPham_KhoClient();
       public PartialViewResult DanhmucNam()
       {
           var listdm = db.ThuongHieuNam().ToList();
           return PartialView(listdm);
       }
       public PartialViewResult DanhmucNu()
       {
           var listdm = db.ThuongHieuNu().ToList();
           return PartialView(listdm);
       }
       public PartialViewResult DanhmucTreEm()
       {
           var listdm = db.ThuongHieuTreEm().ToList();
           return PartialView(listdm);
       }
       public ViewResult danhmuc( string dm, int maloai, int? page)
       {
           var listdm = spk.DanhMuc(dm,maloai).ToList();
           int pageNumber = (page ?? 1);
           int pageSize = 9;
           ViewBag.danhmuc = dm;
           ViewBag.ml = maloai;
           ViewBag.c = listdm.Count();
           return View(listdm.OrderBy(n => n._TenSP).ToPagedList(pageNumber, pageSize));
       }
       
	}
}