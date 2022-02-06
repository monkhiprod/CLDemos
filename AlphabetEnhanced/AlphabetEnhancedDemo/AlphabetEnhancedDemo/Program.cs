using System;

namespace AlphabetEnhanced
{
    class program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(CreateAlphabet());
            //Console.WriteLine($"\n{CreateAlphabet().ToLower()}");

            //Console.WriteLine($"\n{CreateAlphabetBackwards()}");
            //Console.WriteLine($"\n{CreateAlphabetBackwards().ToLower()}");

            Console.Write("How many letters would you like to skip: ");
            string userInput = Console.ReadLine();
            int numberToskip = int.Parse(userInput);
            string skipOver = CreateAlphabetSkip(numberToskip);
            Console.WriteLine(skipOver);

            //string skipOverone = CreateAlphabetSkip(2);
            //Console.WriteLine(skipOverone);

        }

        static string CreateAlphabet()
        {
            string alphabet = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }
            return alphabet;
        }

        static string CreateAlphabetBackwards()
        {
            string alphabetbackwards = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabetbackwards += alpha;
            }
            return alphabetbackwards;
        }

        static string CreateAlphabetSkip(int skip)
        {
            string alphabetskip = "";
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + skip))
            {
                alphabetskip += alpha;
            }
            return alphabetskip;
        }

    }
}