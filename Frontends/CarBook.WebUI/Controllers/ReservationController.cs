﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace CarBook.WebUI.Controllers
{
    public class ReservationController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.v1 = "Araç Kiralama";
            ViewBag.v2 = "Araç Rezervasyon Formu";
            return View();
        }
    }
}

