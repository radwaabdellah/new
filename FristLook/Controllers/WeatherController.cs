using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FristLook.Controllers
{
    
    public class WeatherController : Controller
    {
        private static List<Weather> WeatherList = new List<Weather>()
        {
            new Weather {Id = 1, Country = "Egypt", City = "Alex", WeatherDegree = 22},
            new Weather {Id = 2, Country = "Egypt", City = "Cairo", WeatherDegree = 18}
        };

      [HttpPost]
        public int GetWeather(string country, string city)
        {
            return
                WeatherList
                .First(w => w.City.ToLower() == city.ToLower() && w.Country.ToLower() == country.ToLower())
                    .WeatherDegree;
        }
       [HttpGet]
       
        public int GetWeather(string country)
        {
            return
                WeatherList
                .First(w =>  w.Country.ToLower() == country.ToLower())
                    .WeatherDegree;
        }

    }

    public  class Weather
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int WeatherDegree { get; set; }
    }
}