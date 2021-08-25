using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mitArray = new int[10];

            Random rnd = new Random();
            mitArray[0] = rnd.Next(1001);
            mitArray[1] = rnd.Next(1001);
            mitArray[2] = rnd.Next(1001);
            mitArray[3] = rnd.Next(1001);
            mitArray[4] = rnd.Next(1001);
            mitArray[5] = rnd.Next(1001);
            mitArray[6] = rnd.Next(1001);
            mitArray[7] = rnd.Next(1001);
            mitArray[8] = rnd.Next(1001);
            mitArray[9] = rnd.Next(1001);

            int total = 0;
            for (int i = 0; i < mitArray.Length; i++)
            {
                Console.WriteLine(total);
                    total += mitArray[i];
            }
            Console.WriteLine("");
            Console.WriteLine("Summen er: " + total);

            Console.ReadKey();
        }
    }
}
