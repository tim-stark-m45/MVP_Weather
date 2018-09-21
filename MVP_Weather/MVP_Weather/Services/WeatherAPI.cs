using MVP_Weather.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Weather.Services
{
    public class WeatherAPI
    {
        public string Key { get; set; } = "3f78e3e82d752eba31629cc63fd18799";
        public string Url { get; set; } = @"https://api.openweathermap.org/data/2.5/forecast";

        public void GetWeathers(City city)
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString($"{Url}?q={city.Name}&appid={Key}&units=metric");
            JObject data = JObject.Parse(json);
            List<Weather> weathers = new List<Weather>();
            foreach (var item in data["list"])
            {
                weathers.Add(new Weather
                {
                    Temperature = Double.Parse(item["main"]["temp"].ToString())
                });
            }
            city.Weathers = weathers; 
        }
    }
}
