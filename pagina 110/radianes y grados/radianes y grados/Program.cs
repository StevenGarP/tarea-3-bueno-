using System;

namespace radianes_y_grados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radianes y Grados");
            Console.WriteLine("\nQue quiere convertir");
            Console.WriteLine("1): Radianes a grados");
            Console.WriteLine("2): Grados a radianes");
            int opcion = byte.Parse(Console.ReadLine());
            
            if (opcion == 1)
            {
                Console.Write("ingrese la cantidad de radianes: ");
                double radianes = double.Parse(Console.ReadLine());

                double result_radia;

                result_radia = (radianes * (180 / Math.PI));

                Console.Write("La conversion es: {0}", result_radia);
            }

            else
                {
                Console.Write("ingrese la cantidad de Grados: ");
                double grados = double.Parse(Console.ReadLine());

                double result_grados;

                result_grados = (grados * (Math.PI/180));

                Console.Write("La conversion es: {0}", result_grados);



            }

        }
    }
}
