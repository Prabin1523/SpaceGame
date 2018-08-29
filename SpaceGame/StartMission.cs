using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class StartMission
    {
        public static void startMission()
        {

            Console.WriteLine("                                                                                              Enter your First Destination: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("                                                                                               1 - M63, 2 - Alpha Centuri ");
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            if (a == 1)
            {
                Console.WriteLine("Your Destination is set to Planet M63. ");
                Console.ReadLine();
                Console.Clear();
            }


            else if (a == 2)
            {
                Console.WriteLine("Your Destination is set to Planet Alpha Centuri. ");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Entry, Please Try again. ");
                Console.ReadLine();
            }

        }
    }
}
