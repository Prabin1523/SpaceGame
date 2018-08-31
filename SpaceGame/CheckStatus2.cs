using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Checkstatus
    {


        public  Checkstatus()
        {
            Console.WriteLine("Check Status? ");
            Console.Write("Y: for yes, N: for no");
            Console.ReadLine();

            string status = Console.ReadLine();
            if (status == "Y")
            {
                Console.WriteLine("Fuel: GO");
                Console.WriteLine("MRE: GO");
                Console.WriteLine("Cargo: GO");
                Console.WriteLine("Weapons: GO");
                Console.WriteLine("Ammunition: GO");
                Console.WriteLine("Check Status completed ");
                Console.ReadLine();

            }
            else if (status == "N")
            {
                Console.WriteLine("Roger That. ");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Invalid Entry!");
                Console.ReadLine();
                Console.Clear();

            }


        }


    }
}
