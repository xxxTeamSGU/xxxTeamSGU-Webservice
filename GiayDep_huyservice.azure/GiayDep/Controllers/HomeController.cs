using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GiayDep.Models;

namespace GiayDep.Controllers
{
    public class HomeController : Controller
    {
        Service_SanPham.Service_SanPhamClient db = new Service_SanPham.Service_SanPhamClient();
        public ActionResult Index()
        {
            return View();
        }
    
      
    }
}