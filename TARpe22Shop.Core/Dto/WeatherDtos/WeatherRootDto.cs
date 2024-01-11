namespace TARpe22ShopRohusaar.Core.Dto.WeatherDtos
{
    public class WeatherRootDto
    {
        public HeadlineDto Headline { get; set; }
        public List<DailyForecastsDto> DailyForecasts { get; set; }
        public CloudsDtoOW CloudsOW { get; set; }
        public CoordDtoOW CoordOW { get; set; }
        public MainDtoOW MainOW { get; set; }
        public RainDtoOW RainOW { get; set; }
        public RootDtoOW RootOW { get; set; }
        public SysDtoOW SysOW { get; set; }
        public WeatherDtoOW WeatherOW { get; set; }
        public WindDtoOW WindOW { get; set; }
    }
}
