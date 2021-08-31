using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Her er nogle tal.");
            Console.WriteLine("");
            int[] tal = new int[] { 0, 66, 420, 666, 1138, 1337, 7777};

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Danmarks 5 største byer.");
            string[] byNavne = new string[] { "Hovedstadsområdet", "Aarhus", "Odense", "Aalborg", "Esbjerg" };
            Console.WriteLine("");

            for (int u = 0; u < byNavne.Length; u++)
            {
                Console.WriteLine(byNavne[u]);
            }

            Console.WriteLine("");
            Console.WriteLine("Elever i min klasse.");
            string[] elever = new string[] { "Bjarne", "Bo", "Bob", "Brian", "Ben Kenobi" };
            Console.WriteLine("");

            for (int y = 0; y < elever.Length; y++)
            {
                Console.WriteLine(elever[y]);
            }

            Console.ReadKey();
        }
    }
}
