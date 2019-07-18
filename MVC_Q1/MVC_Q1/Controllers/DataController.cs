using MVC_Q1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Q1.Controllers
{
    public class DataController : Controller
    {
        [HttpPost]
        public ActionResult Save(DetailModel data)
        {
            if (!ModelState.IsValid)
            {
                return View("../Customer/Detail", data);
            }
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
            ViewBag.Name = fileName;
            return View();
        }
    }
}