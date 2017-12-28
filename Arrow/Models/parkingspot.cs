using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrow.Models
{
    public class Parkingspot
    {
        public int mincover { get; set; }
        public int sensortype { get; set; }
        public string restcall { get; set; }
        public string restheader { get; set; }
        public string GapIds { get; set; }
        public string ViewIds { get; set; }
        public int occupied { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public double ax { get; set; }
        public double ay { get; set; }
        public double bx { get; set; }
        public double by { get; set; }
        public double cx { get; set; }
        public double cy { get; set; }
        public double dx { get; set; }
        public double dy { get; set; }
        public string rawRefData { get; set; }
    }
}
