namespace AlphabetDemo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Press the ENTER key to continue for Regular Alphabet\n");
            Console.ReadLine();
            RegularAlphabet();
           
            Console.WriteLine("Press the ENTER key to continue for Reverse Alphabet\n");
            Console.ReadLine();
            ReverseAlphabet();
            
            Console.WriteLine("Press the ENTER key to continue for Skipped Alphabet\n");
            Console.ReadLine();
            SkippedAlphabet();
        }

        static void RegularAlphabet()
        {
            string alphabet = "";
            for (char a = 'A'; a <= 'Z'; a++)
            {
                alphabet += a;
            }
            Console.WriteLine($"{alphabet}\n");
        }

        static void ReverseAlphabet()
        {
            string reversed = "";
            for (char r = 'Z'; r >= 'A'; r--)
            {
                reversed += r;
            }

            Console.WriteLine($"{reversed}\n");
        }

        static void SkippedAlphabet()
        {
            string skip = "";
            for (char s = 'A'; s <= 'Z'; s++, s++)
            {
                skip += s;
            }

            Console.WriteLine($"{skip}\n");
        }
    }
}
