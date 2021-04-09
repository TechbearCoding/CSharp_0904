using System;

namespace Day1_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet skaitli!");
            String cilveks = Console.ReadLine();

            int skaitlis = Convert.ToInt32(cilveks);
            Console.WriteLine("-------------------");

            while (skaitlis % 10 != 0)
            {
                Console.WriteLine(skaitlis);
                skaitlis++;
            }
            Console.WriteLine("Skaitlis " + skaitlis + " dalas ar 10");

        }

        static void Piemeri()
        {
            //for
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
                Console.WriteLine("Hello World!");
            }

            //while un do..while
            //1. piemers
            int izvele = 0;
            while (izvele >= 0)
            {
                Console.WriteLine("Ievadiet skaitli!");

                String ievade = Console.ReadLine();
                izvele = Convert.ToInt32(ievade);
                izvele++;
            }

            //2. piemers
            String a = "";
            while (a != "exit")
            {
                Console.WriteLine("Cikls darbojas!");
                a = Console.ReadLine();
            }


            int i = 0;
            int sum = 0;
            while (i <= 5)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
            //Izvadit skaitlu summu lidz 5
            //1+2+3+4+5*/

            //Izvadit hello world vairakas reizes.
            //Lai lietotajs ievada skaitli- tik reizes Hello world!
        }
    }
}
