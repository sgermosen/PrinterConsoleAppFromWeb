using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrinterConsoleWebPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PrintInvoiceThermal(string[] arrs)
        {
            var p = new Process();

            // Get the file path of your Application (exe)
            string filePath = @"C:\PraySoft\PrinterConsoleApp.exe";
            // string[] arr1 = new string[] { "one", "two", "three" };
            // dd[0] = "ssss";
            var info = new ProcessStartInfo(filePath, String.Join(" ", arrs));
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;

            p = Process.Start(info);
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
         
    }
}