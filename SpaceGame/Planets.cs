using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Planets
    {

        public Planets()
        {
           planets = new List<float>();
        }

        public void AddPlanets(float planet)
        {
            planets.Add(planet);
        }

        List<float> planets;
    }
}
