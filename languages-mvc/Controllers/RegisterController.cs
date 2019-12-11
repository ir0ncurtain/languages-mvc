using languages_mvc.Helpers;
using languages_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace languages_mvc.Controllers
{
    public class RegisterController : BaseController
    {
        // GET: Home    
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register r)
        {
            return View(r);
        }
    }
}