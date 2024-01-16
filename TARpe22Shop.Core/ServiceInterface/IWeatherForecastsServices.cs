using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe22ShopRohusaar.Core.Dto.WeatherDtos;

namespace TARpe22ShopRohusaar.Core.ServiceInterface
{
    public interface IWeatherForecastsServices
    {
        public Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);
        public Task<WeatherResultDtoOW> WeatherDetailOW(WeatherResultDtoOW dto);
    }
}