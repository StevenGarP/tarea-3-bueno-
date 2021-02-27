using System;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula los numeros Primos del 1 al 1000");
            int numero = 2, div = 0;
            while (numero <= 1000)
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (numero % i == 0)
                    {
                        div++;
                    }
                    if (div > 2)
                    {
                        break;
                    }
                }
                if (div == 2)
                {
                    Console.WriteLine("{0} Es un numero primo", numero);
                }
                div = 0;
                numero++;
            }
        }
    }
}
