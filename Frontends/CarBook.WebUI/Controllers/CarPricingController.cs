using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace CarBook.WebUI.Controllers
{
    public class CarPricingController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.v1 = "Paketler";
            ViewBag.v2 = "Araç Fiyat Paketleri";
            return View();
        }
    }
}

