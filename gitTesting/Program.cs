using System;

namespace gitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You will now be able to create your own top-list");
            Console.WriteLine("How many places would you like your list to contain?: ");

            int topPlaces; 
            
            while(int.TryParse(Console.ReadLine(), out topPlaces) == false)
            {
                Console.WriteLine("Please try again, only intergers.");
            }

            int[] userList = new int[topPlaces];
        }
    }
}
