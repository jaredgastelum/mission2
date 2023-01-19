using System;
using System.Linq;
namespace mission2
{
    public class DiceRoll
    {
        public void TotalCount(int rolls)
        {
            int[] totals = new int[rolls];
            int[] output = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Random rd = new Random();

            for (int i = 0; i < totals.Length; i++)
            {
                int dice1 = rd.Next(1, 6);
                int dice2 = rd.Next(1, 6);
                int sum = dice1 + dice2;

                totals[i] = sum;
                //Console.WriteLine(totals[i]);
            }

            for (int i = 0; i < output.Length; i++)
            {
                int occurences = totals.Count(x => x == output[i]);
                string stars = "";

                for (int count = 0; count < occurences; count++)
                {
                    stars = stars + "*";
                }

                Console.WriteLine(output[i] + ": " + stars);
            }

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
