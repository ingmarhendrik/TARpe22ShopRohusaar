using Nancy;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TARpe22ShopRohusaar.ApplicationServices.Services;
using TARpe22ShopRohusaar.Core.Dto.WeatherDtos;

namespace TARpe22ShopRohusaar.ApplicationServices.Services
{
    public class WeatherForecastsServicesOW : IWeatherForecastsServices
    {
        public Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<WeatherResultDtoOW> WeatherDetailOW(WeatherResultDtoOW dto)
        {
            //City Name = "Tallinn, EE" Location = "EUR|EE|EN001|TALLINN" Country = "Estonia"

            string apikey = "9f5e058e16777cbc9cdb78ae841aff58";
            string city = "Tallinn";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q=Tallinn&units=metric&APPID=9f5e058e16777cbc9cdb78ae841aff58";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                WeatherRootDto weatherInfoOW = new JavaScriptSerializer().Deserialize<WeatherRootDto>(json);

                dto.Lon = weatherInfoOW.CoordOW.Lon;
                dto.Lat = weatherInfoOW.CoordOW.Lat;
                dto.Temp = weatherInfoOW.MainOW.Temp;
                dto.FeelsLike = weatherInfoOW.MainOW.FeelsLike;
                dto.TempMin = weatherInfoOW.MainOW.TempMin;
                dto.TempMax = weatherInfoOW.MainOW.TempMax;
                dto.Pressure = weatherInfoOW.MainOW.Pressure;
                dto.Humidity = weatherInfoOW.MainOW.Humidity;

                dto.SeaLevel = weatherInfoOW.MainOW.SeaLevel;
                dto.GrndLevel = weatherInfoOW.MainOW.GrndLevel;
                dto._1h = weatherInfoOW.RainOW._1h;

                dto.Main = weatherInfoOW.WeatherOW.Main;
                dto.Description = weatherInfoOW.WeatherOW.Description;
                dto.Visibility = weatherInfoOW.RootOW.Visibility;
                dto.Name = weatherInfoOW.RootOW.Name;

                dto.Country = weatherInfoOW.SysOW.Country;
   
            }

            return dto;
        }
    }
}
