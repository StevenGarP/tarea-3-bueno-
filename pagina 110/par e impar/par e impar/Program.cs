using System;

namespace par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa te dice si el numero es par o impar :o ");
            Console.Write("\ningrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            
            if ((numero % 2) == 0)
            {
                Console.Write("\nEl numero es par");
            }
            else
            {
                Console.Write("\nEl numero es impar");
            }
        }
    }
}
