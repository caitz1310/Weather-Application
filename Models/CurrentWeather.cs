using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLD_Group_Activity_FA4.Models
{
    public class CurrentWeather
    {
        public Coord cord { get; set; }
        public List<WeatherModel> weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibilty { get; set; }
        public Wind wind { get; set; }
        public Cloud clouds { get; set; }
        public long dt { get; set; }
        public Syst syst { get; set; }
        public long timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public double cod { get; set; }
    }
}
