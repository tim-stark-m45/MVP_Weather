﻿using MVP_Weather.Model;
using MVP_Weather.Services;
using MVP_Weather.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Weather.Presenter
{
    public class WeatherPresenter
    {
        public WeatherView View { get; set; }
        public WeatherDataStorage Storage { get; set; } = new WeatherDataStorage();
        public WeatherAPI Api { get; set; } = new WeatherAPI();

        public void AddCity(City city)
        {
            Storage.AddCity(city);
            View.ShowCities(Storage.Cities);
        }

        public void GetWeather(City city)
        {
            Api.GetWeathers(city);
            View.ShowWeather();
        }
    }
}
