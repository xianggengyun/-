using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 团队项目管理测试.Controllers
{
    public class HomeController : Controller
    {
        //出BUG了
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}