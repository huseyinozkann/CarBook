using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using CarBook.Dto.LocationDtos;
using CarBook.Dto.ReservationDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;




namespace CarBook.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.v1 = "Araç Kiralama";
            ViewBag.v2 = "Araç Rezervasyon Formu";
            ViewBag.v3 = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7044/api/Locations");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.name,
                                                Value = x.LocationID.ToString()
                                            }).ToList();
            ViewBag.v = values2;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateReservationDto createReservationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createReservationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7044/api/Reservations", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Rezervasyon başarıyla kaydedildi.";
                return RedirectToAction("Index", "Default");
            }
            TempData["ErrorMessage"] = "Rezervasyon kaydedilirken bir hata oluştu. Lütfen tekrar deneyin.";
            return View();
        }

    }
}

