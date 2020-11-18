using System;

namespace gitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You will now be able to create your own top-list");
            Console.WriteLine("What would you like to name your toplist?");
            string listName = Console.ReadLine();

            Console.WriteLine("How many places would you like your list to contain?: ");

            int topPlaces; 
            
            while(int.TryParse(Console.ReadLine(), out topPlaces) == false)
            {
                Console.WriteLine("Please try again, only intergers.");
            }

            string[] userList = new string [topPlaces];

            for(int i = 0; i < userList.Length; i++)
            {
                Console.WriteLine($"Enter position {i + 1}: ");
                userList[i] = Console.ReadLine();
            }
        }
    }
}
