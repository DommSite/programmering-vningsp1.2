using System;

namespace tärningskast
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            Console.WriteLine("Hur många tärningar vill du kasta?");
            int antaltärningar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sidor har tärningarna?");
            int antalsidor = int.Parse(Console.ReadLine());


            for (int i = 1; i < antaltärningar+1; i++)
            {
                int landadepå = slump.Next(1, antalsidor+1);
                Console.WriteLine("Tärning nummer " + i + " landade på " + landadepå);
            }

        }
    }
}
