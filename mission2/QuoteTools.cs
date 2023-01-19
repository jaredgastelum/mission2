using System;
namespace mission2
{
    public class QuoteTools
    {
        public int WordCount(string quote)
        {
            string[] words = quote.Split(' ');
            int numWords = 0;

            numWords = words.Length;

            return numWords;
        }

        public int CharacterCount (string quote)
        {
            int numCharacters = 0;

            numCharacters = quote.Length;

            return numCharacters;
        }

        public void LetterCount (string quote)
        {
            char ch = ' ';
            int[] letters = new int[26];

            // Count the letters
            for (int i = 0; i < quote.Length; i++)
            {
                ch = quote[i];
                ch = Char.ToUpper(ch);

                //Check to see if the character is a letter
                if (ch >= 'A' && ch <= 'Z')
                {
                    letters[(ch - 65)]++;
                }
            }

            //Print results
            for (int i = 0; i < letters.Length; i++)
            {
                char letterSymbol = ' ';

                letterSymbol = (char)(i + 65);

                Console.WriteLine(letterSymbol + ": " + letters[i]);
            }

        }
    }
}
