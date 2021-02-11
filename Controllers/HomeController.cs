using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ugb.Models;
namespace Ugb.Controllers
{
    public class HomeController : Controller
    {

        private UgbContext db = new UgbContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}