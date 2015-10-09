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
        DBGiayDepEntities db = new DBGiayDepEntities();
        public ActionResult Index()
        {
            return View();
        }
    
      
    }
}