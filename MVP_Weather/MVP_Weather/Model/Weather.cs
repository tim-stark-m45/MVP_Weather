using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Weather.Model
{
    public class Weather
    {
        public double Temperature { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double WindSpeed { get; set; }
        public double WindDirection { get; set; }
    }
}
