using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Weather.Model
{
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
