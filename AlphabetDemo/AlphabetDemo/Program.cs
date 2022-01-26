using System;

Console.WriteLine("Press any key to continue for Regular Alphabet\n");
Console.ReadLine();

string alphabet = "";
for (char a = 'A'; a <= 'Z'; a++)
{
    alphabet += a;
}

Console.WriteLine($"\n{alphabet}\n");

Console.WriteLine("Press any key to continue for Reverse Alphabet\n");
Console.ReadLine();

string reversed = "";
for (char r = 'Z'; r >= 'A'; r--)
{
    reversed += r;
}

Console.WriteLine($"{reversed}\n");
Console.ReadLine();

Console.WriteLine("Press any key to continue for Skipped Alphabet\n");
Console.ReadLine();

string skip = "";
for (char s = 'A'; s <= 'Z'; s++, s++)
{
    skip += s;
}

Console.WriteLine($"{skip}\n");
Console.ReadLine();