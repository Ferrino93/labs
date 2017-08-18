﻿using System;
using System.Runtime.InteropServices;

namespace SharpProject.Airport
{
    public class MainMenu
    {
        private event EventHandler resetMenu;

        public MainMenu()
        {
            resetMenu += ResetAndRedraw;
            displayMenu();
        }

        public void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Select one of floowing (input a number):");
            Console.WriteLine("1 - Arrivals");
            Console.WriteLine("2 - Departures");
            Console.WriteLine("3 - Prices");
            Console.WriteLine("4 - Passengers");
            Console.WriteLine("5 - Modify info");
            Console.WriteLine("");
            Console.Write("Input:");
            parseInput(Console.ReadLine());
        }

        private void parseInput(string input)
        {
            if (input != null && input.Length <= 0)
            {
                resetMenu(this, null);
            }
            else
            {
                int value = 0;
                try
                {
                    value = int.Parse(input);
                }
                catch (FormatException e)
                {
                    resetMenu(this, null);
                }
                if (value > 5)
                {
                    resetMenu(this, null);
                }
                switch (value)
                {
                    case 1:
                        PrintArrivals();
                        break;
                    case 2:
                        PrintDepartures();
                        break;
                    case 3:
                        PrintPrices();
                        break;
                    case 4:
                        PrintPassengers();
                        break;
                    case 5:
                        DisplayEditMenu();
                        break;
                    default:
                        resetMenu(this, null);
                        break;
                }
            }
        }

        private void DisplayEditMenu()
        {
            Console.Clear();
            Console.WriteLine("EditMeu");
            Console.ReadKey();
            resetMenu(this, null);
        }

        private void PrintPassengers()
        {
            Console.Clear();
            Console.WriteLine("Passengers");
            Console.ReadKey();
            resetMenu(this, null);
        }

        private void PrintPrices()
        {
            Console.Clear();
            Console.WriteLine("Prices");
            Console.ReadKey();
            resetMenu(this, null);
        }

        private void PrintDepartures()
        {
            Console.Clear();
            Console.WriteLine("Departures");
            Console.ReadKey();
            resetMenu(this, null);
        }

        private void PrintArrivals()
        {
            Console.Clear();
            Console.WriteLine("Arrivals");
            Console.ReadKey();
            resetMenu(this, null);
        }

        private void ResetAndRedraw(object sender, EventArgs eventArgs)
        {
            Console.Clear();
            Console.WriteLine("Please, enter a valid input: 1-5");
            Console.ReadKey();
            displayMenu();
        }
    }
}