using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;
using PagedList.Mvc;
using PagedList;

namespace GiayDep.Controllers
{
    public class TimKiemController : Controller
    {
        //
        // GET: /TimKiem/
        //Connect DB
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        Service_SanPham_Kho.Service_SanPham_KhoClient spk = new Service_SanPham_Kho.Service_SanPham_KhoClient();
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            //Lấy từ khóa
            string sTuKhoa = f["txtTimKiem"].ToString();
            ViewBag.STukhoa = sTuKhoa;
            //Tìm trong CSDL
            //List<SanPham> listKQTK = db.SanPhams.Where(n => n.TenSP.Contains(sTuKhoa)).ToList();
            var listKQTK = spk.TimKiemSanPham(sTuKhoa);
            //Phân trang
            int pageNumber = (page ?? 1);
            int pageSize = 9;
            //Nếu không có sản phẩm nào.
            if (listKQTK.Count() == 0)
            {
                //Xuất ra tất cả sản phẩm và phân trang.
                return View(spk.TimKiemSanPham(sTuKhoa).ToPagedList(pageNumber, pageSize));
            }
            ViewBag.tb = listKQTK.Count();
            return View(listKQTK.OrderBy(n => n._TenSP).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem( int? page, string sTuKhoa)
        {
            //Lấy từ khóa
            //string sTuKhoa = f["txtTimKiem"].ToString();
            ViewBag.STukhoa = sTuKhoa;
            //Tìm trong CSDL
            //List<SanPham> listKQTK = db.SanPhams.Where(n => n.TenSP.Contains(sTuKhoa)).ToList();
            var listKQTK = spk.TimKiemSanPham(sTuKhoa);
            //Phân trang
            int pageNumber = (page ?? 1);
            int pageSize = 9;
            //Nếu không có sản phẩm nào.
            if (listKQTK.Count() == 0)
            {
                //Xuất ra tất cả sản phẩm và phân trang.
                return View(spk.TimKiemSanPham(sTuKhoa).ToPagedList(pageNumber, pageSize));
            }
            ViewBag.tb =listKQTK.Count();
            return View(listKQTK.OrderBy(n => n._TenSP).ToPagedList(pageNumber, pageSize));
        }
	}
}