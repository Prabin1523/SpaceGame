﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();
        }

        public static void gameTitle()
        {
            
            Console.WriteLine("Welcome to SpaceGame-1 (-_-)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Every Great Journey Begins With a Dream! ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Which will sometime fail Bigly! Anyways! press Enter...");
            Console.ReadLine();
            Console.Clear();
            
            Console.Write("Enter your First Name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Enter your Last Name: ");
            myLastName = Console.ReadLine();

            Console.Write("Welcome LOSER------------ (-_-) ! " + "Now Press Enter to begin: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Congratulation  " + myFirstName + "! You have earned 1,000 Credits. ");
            Console.ReadLine();
            
            Console.WriteLine("Select your Spaceship - A, B, or C");
            string xuserValue = Console.ReadLine();
            Console.ReadLine();

            if (xuserValue == "C")
            {
                Console.WriteLine("Sorry! You do not have enough credits for this option. Select other options. ");
                Console.ReadLine();
            }

            else if (xuserValue == "A")
            {
                string message = "Thunder-Bird! Great Choice... ";
                
                Console.WriteLine(message);
                Console.Write("Thunder-Bird - Maximun Speed 1 light year per year. Price - 500 credits. ");
                Console.ReadLine();
            }
            else if (xuserValue == "B")
            {
                string message = "Virgin-Galactic! Great Choice.... ";
                Console.WriteLine(message);
                Console.Write("Virgin-Galactic has maximum speed of 5 light years per year. Price 600 credits. ");
                Console.ReadLine();
            }
            else
            {
                string message = "Sorry! Invalid Entry. Plase Enter option A, B or C. ";
                Console.WriteLine(message);
                Console.ReadLine();                
            }








            message = message + "You lose. ";







            //switch (option)
            //{
            //    case "1":
            //    case "A":
            //    case "B":

            //}
        }

        public static void first()
        {

        }

        public static void second()
        {

        }

        public static void third()
        {

        }

        public static void YouWin()
        {

        }

        public static void GameOver()
        {

        }

    }   
}









/*
case 1 
    Planet A
    Ship A
    Carryon A

case 2
    Planet A
    Ship B
    Carryon  B

case 3
    Planet A
    Ship B
    Carryon A

case 4
    Planet A
    Ship A
    Carryon B


case 5
    Planet B
    Ship B
    Carryon B

case 6
    Planet B
    Ship A
    Carryon B

case 7
    Planet B
    Ship B
    Carryon A
    */


