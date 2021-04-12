using System;

namespace Day2_loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodes_piemers1();
            //Mainigo_Piemers();
            Konvertacijas_Piemers();
        }

        static void Konvertacijas_Piemers()
        {
            Console.WriteLine("Ievadiet 1. skaitli!");
            String ievade = Console.ReadLine();
            int sk1 = Convert.ToInt32(ievade);

            //so var apvienot 1 rinda
            //int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet 2. skaitli!");
            ievade = Console.ReadLine();
            int sk2 = Convert.ToInt32(ievade);

            int rezultats = sk1 + sk2;
            Console.WriteLine("Rezultats ir " + rezultats);
        }

        static void Uzdevums1()
        {
            //Programma pajauta cilveka vardu
            Console.WriteLine("Kads ir Tavs vards?");
            //Cilveks ievada
            String vards = Console.ReadLine();
            //Programma izvada tekstu "Sveiki, {cilveka vards}!"
            Console.WriteLine("Sveiki, " + vards + "!");
        }

        static void Ievades_Piemers()
        {
            Console.WriteLine("Ievadiet simbolu virkni!");
            String ievade = Console.ReadLine();
            Console.WriteLine("Cilveks ievadija " + ievade);
        }

        static void Mainigo_Piemers()
        {
            //int- (integer) vesels skaitlis
            //float, double- skaitlis
            //bool- boolean- true vai false
            //string un char- simbolu virkne un viens simbols

            //deklaracija- noradit mainiga tipu un nosaukumu
            int a; //deklaracija
            a = 0; //definacija
            Console.WriteLine(a);

            int b = 0; //deklaracija un definiciju var apvienot
            b = 3;

            String c = "abcd";

            String d = "2";
            int aa = 2;
            //Šīs vērtības nav vienādas!

            Console.WriteLine(2 + 2);
            Console.WriteLine("2+2");
            Console.WriteLine(2 + 2 + " = 2 + 2");
        }

        static void Metodes_piemers1()
        {
            for (int i = 0; i < 10; i++)
            {
                Test();
            }
        }

        static void Test()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }
    }
}
