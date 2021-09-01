using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] navne = new string[5];
           
            Console.WriteLine("Indtast fem navne.");

            for (int i = 0; i < 5; i++)
            {
                navne[i] = Console.ReadLine();
            }
            Console.WriteLine("\nDe fem naven du har indtastet er:");
            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine(navne [i]);
            }
        }
    }
}
