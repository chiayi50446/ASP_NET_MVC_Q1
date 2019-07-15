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
        public new ActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public new ActionResult Detail(DetailModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }
            TempData["detail"] = data;
            return RedirectToAction("Check");
        }

        public ActionResult Check()
        {
            return View(TempData["detail"]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Check(DetailModel data)
        {
            if (!Directory.Exists(@"D:\temp\"))
            {
                Directory.CreateDirectory(@"D:\temp\");
            }
            string fileName = "Detail-" + DateTime.Now.ToString("HHmmssMMddyyyy");
            StreamWriter sw = new StreamWriter(@"D:\Temp\" + fileName + ".txt");
            sw.WriteLine("Name : " + data.Name);
            sw.WriteLine("Phone : " + data.Phone);
            sw.WriteLine("Email : " + data.Email);
            sw.Close();
            return RedirectToAction("Save", "Data");
        }
    }
}