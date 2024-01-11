﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe22ShopRohusaar.Core.Dto.WeatherDtos
{
    public class WeatherResultDtoOW
    {
        public int All { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int SeaLevel { get; set; }
        public int GrndLevel { get; set; }
        public double _1h { get; set; }
        //public Coord Coord { get; set; }
        //public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        //public Main Main { get; set; }
        public int Visibility { get; set; }
        //public Wind Wind { get; set; }
        //public Rain Rain { get; set; }
        //public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        //public Sys Sys { get; set; }
        public int Timezone { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public int Type { get; set; }
        //public int Id { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        //public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }
}
