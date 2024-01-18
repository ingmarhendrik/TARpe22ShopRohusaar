using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TARpe22ShopRohusaar.Core.ServiceInterface;
using TARpe22ShopRohusaar.Core.Dto.WeatherDtos;
using TARpe22ShopRohusaar.Models.Weather;

namespace TARpe22ShopRohusaar.Controllers
{
    public class WeatherForecastsControllerOW : Controller
    {
        private readonly IWeatherForecastsServices _weatherForecastsServicesOW;
        public WeatherForecastsControllerOW(IWeatherForecastsServices weatherForecastsServicesOW)
        {
            _weatherForecastsServicesOW = weatherForecastsServicesOW;
        }

        public IActionResult Index()
        {
            WeatherViewModelOW vm = new WeatherViewModelOW();
            return View(vm);
        }

        [HttpPost]
        public IActionResult ShowWeather()
        {
            string city = Request.Form["City"];

            if (!string.IsNullOrEmpty(city))
            {
                WeatherResultDtoOW dto = new();
                dto.City = city;
                _weatherForecastsServicesOW.WeatherDetailOW(dto);

                WeatherViewModelOW vm = new()
                {
                    City = dto.City,
                    Timezone = dto.Timezone,
                    Temperature = dto.Temperature,
                    Pressure = dto.Pressure,
                    Humidity = dto.Humidity,
                    Lon = dto.Lon,
                    Lat = dto.Lat,
                    Main = dto.Main,
                    Description = dto.Description,
                    Speed = dto.Speed
                };

                return View("City", vm);
            }

            return View();
        }
    }
}