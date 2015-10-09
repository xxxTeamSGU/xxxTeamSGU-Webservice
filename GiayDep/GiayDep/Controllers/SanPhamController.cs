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
        DBGiayDepEntities db = new DBGiayDepEntities();
        public PartialViewResult SanphammoiPartial()
        {
            var listSanphammoi = db.SanPhams.Take(6).ToList();
            return PartialView(listSanphammoi);
        }
        public PartialViewResult SanphamkhuyenmaiPartial()
        {
            var listkhuyenmai = db.SanPhams.Take(6).ToList();
            return PartialView(listkhuyenmai);
        }
        public ViewResult Chitietsanpham(int masp)
        {
            SanPham sanpham = db.SanPhams.SingleOrDefault(n=>n.MaSP == masp);
            if (sanpham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sanpham);
        }
       
	}
}