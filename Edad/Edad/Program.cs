using System;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edades y Promedios");
            Console.WriteLine("\nCuantas edades desea ingresar");
            int edad = int.Parse(Console.ReadLine());

            int[] datos = new int[edad];
            int mayor=0, menor=0;
            int suma = 0, suma1 = 0;
            for (int i = 0; i < edad; i++)
            {
                Console.WriteLine("Ingrese la edad: {0}", (i + 1));
                datos[i] = Convert.ToInt32(Console.ReadLine());
                suma += datos[i];
                suma1 = (suma / edad);
            }
            for ( int i = 0; i < edad; i++)
            {
                if (datos[i] > mayor)
                    mayor = datos[i];
                else if (datos[i] < menor)
                    menor = datos[i];
            }
            Console.WriteLine("El promedio de las edades es: {0}", suma1);
            Console.WriteLine("La edad mayor es: {0}", mayor);
            Console.WriteLine("La edad menor es: {0}", menor);
        }
    }
}
