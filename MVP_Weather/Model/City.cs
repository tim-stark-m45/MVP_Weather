using System;
using System.Collections.Generic;

namespace MVP_Weather.Model
{
    [Serializable]
    public class City
    {
        public string Name { get; set; }
        public List<Weather> Weathers { get; set; } = new List<Weather>();

        public override string ToString()
        {
            return Name;
        }
    }
}
