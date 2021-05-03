using System;

namespace Masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Izveidot metodi CreateRandomArray ->  atgriež masīvs
            //garumu ģenerē ar random funkciju (5..10), elementi- (1..30)
            int[] generetais = CreateRandomArray();

            for(int skaititajs = 0; skaititajs < generetais.Length; skaititajs++)
            {
                Console.Write(generetais[skaititajs] + " ");
            }
            Console.WriteLine();

            //1. Izveidot getEvenSum (skaitlu masivs) - > para elementu summa
            //1, 6, 8, 9, 10, 11 -> 6 + 8 + 10 - > 24

            int paraSkaitluSumma = GetEvenSum(generetais);

            Console.WriteLine("Para skaitlu summa ir " + paraSkaitluSumma);
            Console.WriteLine("Para skaitlu summa ir {0}", paraSkaitluSumma);
            Console.WriteLine($"Para skaitlu summa ir {paraSkaitluSumma}");
        }

        static int GetEvenSum(int[] masivs)
        {
            int summa = 0;

            for (int skaititajs = 0; skaititajs < masivs.Length; skaititajs++)
            {
                if (masivs[skaititajs] % 2 == 0)
                {
                    summa = summa + masivs[skaititajs];
                }
            }

            return summa;
        }

        static int[] CreateRandomArray()
        {
            Random rnd = new Random();

            int garums = rnd.Next(5, 11);

            int[] skaitluMasivs = new int[garums];

            for (int skaititajs = 0; skaititajs < skaitluMasivs.Length; skaititajs++)
            {
                skaitluMasivs[skaititajs] = rnd.Next(1, 31);
            }

            return skaitluMasivs;
        }
    }
}
