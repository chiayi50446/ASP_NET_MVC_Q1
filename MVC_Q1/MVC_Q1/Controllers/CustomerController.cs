using MVC_Q1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Q1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(DetailModel data)
        {
            if (!ModelState.IsValid)
            {
                return View("Detail", data);
            }
            return View(data);
        }
    }
}