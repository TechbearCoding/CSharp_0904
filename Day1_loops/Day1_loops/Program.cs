using System;

namespace Day1_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hello World!");
            }

            //while un do..while
            //1. piemers
            int izvele = 0;
            while(izvele >= 0)
            {
                Console.WriteLine("Ievadiet skaitli!");

                String ievade = Console.ReadLine();
                izvele = Convert.ToInt32(ievade);
            }

            //2. piemers
            String a = "";
            while(a != "exit")
            {
                Console.WriteLine("Cikls darbojas!");
                a = Console.ReadLine();
            }

        }
    }
}
