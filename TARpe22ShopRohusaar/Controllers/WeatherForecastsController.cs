using Microsoft.AspNetCore.Mvc;
using TARpe22ShopRohusaar.ApplicationServices.Services;
using TARpe22ShopRohusaar.Core.Dto.WeatherDtos;
using TARpe22ShopRohusaar.Models.Weather;

namespace TARpe22ShopRohusaar.Controllers
{
    public class WeatherForecastsController : Controller
    {
        private readonly IWeatherForecastsServices _weatherForecastsServices;
        public WeatherForecastsController(IWeatherForecastsServices weatherForecastsServices)
        {
            _weatherForecastsServices = weatherForecastsServices;
        }
        public IActionResult Index()
        {
            WeatherViewModel vm = new WeatherViewModel();
            return View(vm);
        }

        public IActionResult IndexOW()
        {
            WeatherViewModelOW vm = new WeatherViewModelOW();
            return View(vm);
        }


        [HttpPost]
        public IActionResult ShowWeather()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecasts");
            }
            return View();
        }

        [HttpPost]
        public IActionResult ShowWeatherOW()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("CityOW", "WeatherForecastsOW");
            }
            return View();
        }


        [HttpGet]
        public IActionResult City()
        {
            WeatherResultDto dto = new WeatherResultDto();
            WeatherViewModel vm = new WeatherViewModel();

            _weatherForecastsServices.WeatherDetail(dto);

            vm.Date = dto.EffectiveDate;
            vm.EpochDate = dto.EffectiveEpochDate;
            vm.Severity = dto.Severity;
            vm.Text = dto.Text;
            vm.Category = dto.Category;
            vm.MobileLink = dto.MobileLink;
            vm.Link = dto.Link;
            vm.Category = dto.Category;

            vm.TempMinValue = dto.TempMinValue;
            vm.TempMinUnit = dto.TempMinUnit;
            vm.TempMinUnitType = dto.TempMinUnitType;

            vm.TempMaxValue = dto.TempMaxValue;
            vm.TempMaxUnit = dto.TempMaxUnit;
            vm.TempMaxUnitType = dto.TempMaxUnitType;

            vm.DayIcon = dto.DayIcon;
            vm.DayIconPhrase = dto.DayIconPhrase;
            vm.DayHasPrecipitation = dto.DayHasPrecipitation;
            vm.DayPrecipitationType = dto.DayPrecipitationType;
            vm.DayPrecipitationIntensity = dto.DayPrecipitationIntensity;

            vm.NightIcon = dto.NightIcon;
            vm.NightIconPhrase = dto.NightIconPhrase;
            vm.NightHasPrecipitation = dto.NightHasPrecipitation;
            vm.NightPrecipitationType = dto.NightPrecipitationType;
            vm.NightPrecipitationIntensity = dto.NightPrecipitationIntensity;

            return View(vm);

        }

        [HttpGet]
        public IActionResult CityOW()
        {
            WeatherResultDtoOW dto = new WeatherResultDtoOW ();
            WeatherViewModelOW vm = new WeatherViewModelOW();

            _weatherForecastsServices.WeatherDetailOW(dto);

            vm.Lon = dto.Lon;
            vm.Lat = dto.Lat;
            vm.Temp = dto.Temp;
            vm.FeelsLike = dto.FeelsLike;
            vm.TempMin = dto.TempMin;
            vm.TempMax = dto.TempMax;
            vm.Pressure = dto.Pressure;
            vm.Humidity = dto.Humidity;
            vm.SeaLevel = dto.SeaLevel;
            vm.GrndLevel = dto.GrndLevel;

            vm._1h = dto._1h;
            vm.Main = dto.Main;
            vm.Description = dto.Description;
            vm.Visibility = dto.Visibility;

            vm.Name = dto.Name;
            vm.Country = dto.Country;

            return View(vm);

        }
    }
}
