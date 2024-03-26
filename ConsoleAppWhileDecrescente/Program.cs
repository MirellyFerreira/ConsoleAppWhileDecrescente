using System;

namespace ConsoleAppLaçoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 100;

            while (cont >= 0)
            {
                Console.WriteLine(cont);
                cont--;
            }
            Console.ReadKey();
        }
    }
}
