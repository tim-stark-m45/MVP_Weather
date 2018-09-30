using MVP_Weather.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Weather.Services
{
    public class WeatherDataStorage
    {
        public List<City> Cities { get; set; } = new List<City>();

        public void AddCity(City city)
        {
            if (String.IsNullOrWhiteSpace(city.Name))
            {
                throw new Exception("Название города должно быть заполнено!");
            }
            Cities.Add(city);
        }

        public void RemoveCity(int id)
        {
            Cities.RemoveAt(id);
        }
    }
}
