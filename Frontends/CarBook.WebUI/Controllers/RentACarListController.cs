using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using CarBook.Dto.RentACarDtos;


namespace CarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var bookpickdate = TempData["bookpickdate"];
            var bookoffdate = TempData["bookoffdate"];
            var timepick = TempData["timepick"];
            var timeoff = TempData["timeoff"];
            var locationID = TempData["locationID"];

            ViewBag.bookpickdate = bookpickdate;
            ViewBag.bookoffdate = bookoffdate;
            ViewBag.timepick = timepick;
            ViewBag.timeoff = timeoff;
            ViewBag.locationID = locationID;

            //filterRentACarDto.locationID = int.Parse(locationID.ToString());
            //filterRentACarDto.available = true;

            id = int.Parse(locationID.ToString());
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7044/api/RentACars?locationID={id}&available=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

