using TARpe22ShopRohusaar.Core.Dto.WeatherDtos;

namespace TARpe22ShopRohusaar.ApplicationServices.Services
{
    public interface IWeatherForecastsServices
    {
        Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);
        Task<WeatherResultDtoOW> WeatherDetailOW(WeatherResultDtoOW dto);
    }
}