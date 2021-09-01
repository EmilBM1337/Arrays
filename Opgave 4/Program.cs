using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 4.1
            /*
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
            */

            //Opgave 4.2

            int[] højde = new int[10];
            int svar = 0;

            Console.WriteLine("Indtast højden på ti personer, og jeg regner jeres gennemsit.");

            for (int i = 0; i < 10; i++)
            {
                højde[i] = Convert.ToInt32(Console.ReadLine());
                svar = svar + højde[i];
            }
            double x = svar / højde.Length;
            Console.WriteLine("\nGennemsnittet af højden er: " + x);
        }
    }
}
