using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 100; i++)
           {
               Console.WriteLine(FizzBuzz.Output(i));
           }

           Console.WriteLine("Press enter to exit");
           Console.ReadLine();
        }
    }
}
