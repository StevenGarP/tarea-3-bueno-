using System;

namespace IMPUESTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impuestos: ");
            Console.WriteLine("Ingrese nombre del producto (si es MEDICINA no tiene impuesto)");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = double .Parse(Console.ReadLine());

            if (nombre == "MEDICINA")
            {
                Console.WriteLine("Este producto no tiene impuesto: ");
            }
            else
            {
                double impuesto = precio * 0.12;

                Console.WriteLine("el impuesto de este producto es: {0}",impuesto );
            }
        }
    }
}
