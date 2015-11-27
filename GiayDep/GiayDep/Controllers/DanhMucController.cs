using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using GiayDep.Service_SanPham;

namespace GiayDep.Controllers
{
    public class DanhMucController : Controller
    {
        //
        // GET: /DanhMuc/
       Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
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
       
	}
}