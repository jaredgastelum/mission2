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
                "Total number of rolls = " + input);
            dc.TotalCount(rolls);

            //QuoteTools qt = new QuoteTools();

            //string userQuote = "";

            //Console.WriteLine("Welcome to the quote analyzer");
            //Console.WriteLine("Please enter a quote");

            //userQuote = Console.ReadLine();

            //Console.WriteLine("Characters: " + qt.CharacterCount(userQuote));
            //Console.WriteLine("# Words: " + qt.WordCount(userQuote));
            //Console.WriteLine("Count of Letters:");
            //qt.LetterCount(userQuote);
        }
    }
}

