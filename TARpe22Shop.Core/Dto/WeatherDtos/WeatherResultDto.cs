using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TARpe22ShopRohusaar.Core.Dto.WeatherDtos
{
    public class WeatherResultDtoOW
    {
        public double CoordLon { get; set; }
        public double CoordLat { get; set; }
        public int WeatherId { get; set; }
        public string WeatherMain { get; set; }
        public string WeatherDescription { get; set; }
        public string WeatherIcon { get; set; }
        public string WeatherBase { get; set;}
        public double MainTemp { get; set; }
        public double MainFeelsLike { get; set; }
        public double MainTempMin { get; set; }
        public double MainTempMax { get; set; }
        public int MainPressure { get; set; }
        public int MainHumidity { get; set; }
        public int MainSeaLevel { get; set; }
        public int MainGrndLevel { get; set; }
        public int Visibility { get; set; }
        public double WindSpeed { get; set; }
        public int WindDeg { get; set; }
        public double WindGust { get; set; }
        public double Rain1h { get; set; }
        public double Rain3h { get; set; }
        public double Snow1h { get; set; }
        public double Snow3h { get; set; }
        public int CloudsAll { get; set; }
        public int Dt { get; set; }
        public int SysType { get; set; }
        public int SysId { get; set; }
        public string SysMessage { get; set; }
        public string SysCountry { get; set; }
        public int SysSunrise { get; set; }
        public int SysSunset { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

    }
}
