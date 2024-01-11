using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TARpe22ShopRohusaar.Core.Dto.WeatherDtos
{
    public class RainDtoOW
    {
        [JsonProperty("1h")]
        public double _1h { get; set; }
    }
}
