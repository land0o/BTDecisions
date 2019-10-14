using System;

namespace decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bobs big Giveaway!");
            // Console.Write("Choose a door: 1, 2, 3: ");
            // string userValue = Console.ReadLine();
            // string message = "";


            // if (userValue == "1")
            //     message = "You won a new Car!";
            // else if (userValue == "2")
            //     message = "You won a new Boat!";
            // else if (userValue == "3")
            //     message = "You won a new Cat!";
            // else
            // {
            //     message = "Sorry user input can not be read. ";
            //     //message = message + "You Lose.";
            //     message += "You Lose.";
            // }
            // Console.WriteLine(message);
            // Console.ReadLine();

            // Conditional Operator

            Console.WriteLine("Bobs big Giveaway!");
            Console.Write("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "Boat" : "strand of lint";
            // Console.Write("You won a " + message + ".");
            // Console.Write(message);
            // Console.Write(".");
            // Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0} therefore You won a {1}.", userValue, message);
            Console.ReadLine();




        }
    }
}
