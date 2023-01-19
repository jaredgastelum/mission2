using System;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoll dc = new DiceRoll();

            string input;
            int rolls;

            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
            Console.WriteLine("How many dice rolls would you like to simulate?: ");
            input = Console.ReadLine();

            rolls = Convert.ToInt32(input);


            //Print Results
            Console.WriteLine("\n" + "DICE ROLLING SIMPULATION RESULTS" + "\n" +
                "Each '*' represents 1% of the total number of rolls." + "\n" +
                "Total number of rolls = " + input + "\n");

            dc.TotalCount(rolls);
        }
    }
}

