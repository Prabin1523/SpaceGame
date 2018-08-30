using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class DistanceTravelled
    {

        public static double travelTime(double W)
        {
            double travelTime = 0;
            double distance = 0;

            travelTime = distance / (Math.Pow(W, 10 / 3) + Math.Pow(10-W, -11 / 3));
            return travelTime;

         
        }
    }
}
