using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, num, i, auxiliar;
            Console.Write("Ingrese el número de numeros de Fibonacci que desea mostrar: ");
            num = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < num; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
        }
    }
}
