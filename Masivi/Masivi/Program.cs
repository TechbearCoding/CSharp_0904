using System;

namespace Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uztaisīt tā, lai cilvēks izvēlas masīva garumu
            //Uztaisīt tā, lai masīvu aizpilda ar gadījuma skaitļiem
            //Parādīt skaitļus uz ekrāna


            Console.WriteLine("Ievadat masivu garumu!");
            String ievade = Console.ReadLine();
            int garums = Convert.ToInt32(ievade);

            int[] masivs = new int[garums];

            Random rd = new Random();
            for(int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = rd.Next(1, 11);
            }

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine(masivs[i]);
            }

        }

        static void Piemers()
        {
            int a = 3;

            double[] piemers1 = { 5.5, 7, 3, 1 };

            int[] piemers2 = new int[5];

            //piemers2[0] = -1;
            //piemers2[1] = 2;
            //piemers2[2] = 999;
            //piemers2[3] = 4;
            //piemers2[4] = 567;

            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(piemers2[0]);
            for (int i = 0; i < piemers2.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                String ievade = Console.ReadLine();
                piemers2[i] = Convert.ToInt32(ievade);
            }

            for (int i = 0; i < piemers2.Length; i++)
            {
                Console.WriteLine(piemers2[i]);
            }
        }
    }
}
