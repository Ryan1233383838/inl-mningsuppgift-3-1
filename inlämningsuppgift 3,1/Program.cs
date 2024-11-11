using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du? (år)");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16)
            {
                Console.WriteLine("du får delta i tävlingen");
            }
           else if (ålder < 19)
            {
                Console.WriteLine("du får inte delta i tävlingen");
            }
        }
    }
}