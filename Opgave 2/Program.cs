using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] forNavn = new string[7] { "Bjarne", "Quang", "Donald", "Joe", "Kim", "Peter", "Mark"};
            string[] efterNavn = new string[7] { "Simonsen", "Jensen", "Trump", "Biden", "Jong-un", "Madsen", "Thomsen"};
            Random rnd = new Random();

            for ()
            {
                string randomFirstName = forNavn[rnd.Next(0, forNavn.Length)];
                string randomLastName = efterNavn[rnd.Next(0, efterNavn.Length)];

                Console.WriteLine(randomFirstName + " " + randomLastName);
            }

            Console.ReadKey();
        }
    }
}
