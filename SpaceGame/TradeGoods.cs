using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class TradeGoods
    {
        public TradeGoods()
        {
            Start:

            Console.WriteLine("Do you want to trade your goods for Dark Matter? ");
            Console.Write("Type YES, or NO: ");
            Console.ReadLine();
           

            string trade = Console.ReadLine();
            if (trade == "YES" || trade == "yes")
            {
                Console.WriteLine("Your good has been traded for Dark Matter.");
                Console.ReadLine();
                Console.Clear();

            }
            else if (trade == "NO" || trade == "no")
            {
                Console.WriteLine("No Trade was made. ");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Entry Please Enter the correct input. ");
                Console.ReadLine();
                Console.Clear();
                goto Start;
            }

        }





    }
}

  