using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatif
{
    
    class Position
    {
       public static double _latitude;
        public double Longitude { get; set; }

        public Position()
        {
            _latitude = 0;
            Longitude = 0;
        }

        public Position(double la, double lon)
        {
            _latitude = la;
            Longitude = lon;
        }

        public void Afficher()
        {
            Console.WriteLine("Latitude {0} N; Longitude {1} O",_latitude, Longitude);
        }



    }



}
