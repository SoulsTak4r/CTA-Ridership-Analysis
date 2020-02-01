using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program.Models
{
    public class Stops
    {
        public int stopID { get; set; }

        public string stopName { get; set; }

        public string direction { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public string color { get; set; }

        public string ADA { get; set; }

        public Stops()
        { }

        public Stops (int sid, string sname, string sdirection, double slati, double slongi, string scolor, string sada)
        {
            stopID = sid;
            stopName = sname;
            direction = sdirection;
            latitude = slati;
            longitude = slongi;
            color = scolor;
            ADA = sada;
        }

    }
}
