using System;
namespace fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening1 = Console.ReadLine();
            Console.WriteLine("Skriv en till");
            string mening2 = Console.ReadLine();
            Console.WriteLine("Det som var längst var " + Längst(mening1, mening2));
        }

        static string Längst(string mening1, string mening2)
        {
            if (mening1.Length > mening2.Length)
            {
                return mening1;
            }
            else if (mening1.Length < mening2.Length)
            {
                return mening2;
            }
            else
            {
                return mening1;
            }

        }

        static int Längst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal1 < tal2)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
        }
    }
}