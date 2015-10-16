using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;

namespace GiayDep.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
        public PartialViewResult SanphammoiPartial()
        {
            var listsanphammoi = db.SanphammoiPartial().ToList();
            return PartialView(listsanphammoi);
        }
        public PartialViewResult SanphamkhuyenmaiPartial()
        {
            var listkhuyenmai = db.SanphamkhuyenmaiPartial().ToList();
            return PartialView(listkhuyenmai);
       }
        public ViewResult Chitietsanpham(int masp)
        {
            var chitiet = db.Chitietsanpham(masp);
            return View(chitiet);
        }
       
	}
}