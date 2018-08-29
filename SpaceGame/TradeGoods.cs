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
            Console.WriteLine("Do you want to trade your goods for Dark Matter? ");
            Console.WriteLine("Type YES, or NO: ");
            Console.ReadLine();

            string trade = Console.ReadLine();
            if (trade == "YES")
            {
                Console.WriteLine("Your good has been traded for Dark Matter.");
                Console.ReadLine();
                Console.Clear();

            }
            else if (trade == "NO")
            {
                Console.WriteLine("Roger, No Trade. ");
                Console.ReadLine();
                Console.Clear();
            }
        }





    }
}

  