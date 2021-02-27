using System;

namespace tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de Multiplicar 5\n");

            for (int i = 5; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }
            }

        }
    }
}
