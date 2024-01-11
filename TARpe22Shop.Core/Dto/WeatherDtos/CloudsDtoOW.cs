using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TARpe22ShopRohusaar.Core.Dto.WeatherDtos
{
    public class CloudsDtoOW
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
