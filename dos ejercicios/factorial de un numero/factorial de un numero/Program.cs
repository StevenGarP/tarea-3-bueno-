using System;

namespace factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
                verificar(num);
            } while (num < 0);
            factorial(num);
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo...\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de {0} es: {1}", n, fact);
        }
    }
}
