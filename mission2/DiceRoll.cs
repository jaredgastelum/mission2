using System;
namespace mission2
{
    public class DiceRoll
    {
        public int TotalCount(int rolls)
        {
            int[] totals = new int[rolls];
            Random rd = new Random();

            for (int i = 0; i < rolls; i++)
            {
                int dice1 = rd.Next(1, 6);
                int dice2 = rd.Next(1, 6);
                int sum = dice1 + dice2;

                totals[i] = sum;
            }

            Console.WriteLine("hello");
            return 0;
        }

        public ushort WordCount(string quote)
        {
            string[] words = quote.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            return 0;
        }
    }
}
