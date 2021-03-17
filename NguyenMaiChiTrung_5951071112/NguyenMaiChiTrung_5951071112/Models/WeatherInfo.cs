using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenMaiChiTrung_5951071112.Models
{
    public class WeatherInfo
    {
        string Location;
        float Degree;
        DateTime dateTime;

        public string Location1 { get => Location; set => Location = value; }
        public float Degree1 { get => Degree; set => Degree = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}