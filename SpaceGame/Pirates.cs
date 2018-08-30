using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Pirates
    {
        public Pirates()
        {
            Console.WriteLine("Warning! Warning!");
            Console.WriteLine("Space Pirates! Space Pirates!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Our radar has detected Space Pirates.");
            Console.WriteLine("Do you want to engage, or turn around and go different direction. ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Type engage to engage, or type disengage to turn around. ");
            Console.ReadLine();
            Console.Clear();

            string piratesOption = Console.ReadLine();

            if (piratesOption == "engage" || piratesOption == "Engage") ;
            {
                Console.WriteLine("Engage Confirmed");

                Console.WriteLine("                                                                                                              .          ");
                Console.WriteLine("                                                                                                             ...                    ");
                Console.WriteLine("                                                                                                     |      .....       |      ");
                Console.WriteLine("                                                                                                    .      .......       .       ");
                Console.WriteLine("                                                                                                   .      .........       .      ");
                Console.WriteLine("                                                                                                   .    .....( ).....     .     ");
                Console.WriteLine("                                                                                                   .     ....   ....      .        ");
                Console.WriteLine("                                                                                                    .     .... ....      .         ");
                Console.WriteLine("                                                                                                      .      ...       .       ");
                Console.WriteLine("                                                                                                        .   .....   .      ");
                Console.ReadLine();

            }

        }
        }
    }
}
