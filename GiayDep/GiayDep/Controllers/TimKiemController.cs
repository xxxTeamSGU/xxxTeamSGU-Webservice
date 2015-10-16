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
        Service_SanPham.Service_SanPham db = new Service_SanPham.Service_SanPham();
        //[HttpPost]
        //public ActionResult KetQuaTimKiem(FormCollection f,int? page)
        //{
        //    //Lấy từ khóa
        //    string sTuKhoa = f["txtTimKiem"].ToString();
        //    //Tìm trong CSDL
        //    List<SanPham> listKQTK = db.SanPhams.Where(n=> n.TenSP.Contains(sTuKhoa)).ToList();
            
        //    //Phân trang
        //    int pageNumber = (page ?? 1);
        //    int pageSize = 3;
        //    //Nếu không có sản phẩm nào.
        //    if(listKQTK.Count()==0)
        //    {
        //       ViewBag.ThongBao("Không tìm thấy sản phẩm nào.");
        //        //Xuất ra tất cả sản phẩm và phân trang.
        //        return View(db.SanPhams.OrderBy(n => n.TenSP).ToPagedList(pageNumber,pageSize));
        //    }
        //    return View(listKQTK.OrderBy(n=> n.TenSP).ToPagedList(pageNumber,pageSize));
        //}
	}
}