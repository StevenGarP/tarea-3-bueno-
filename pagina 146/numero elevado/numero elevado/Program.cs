using System;

namespace numero_elevado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleve un numero a cualquier potencia");
            Console.WriteLine("\nIngrese un numero: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el exponente a elevar: ");
            int exponente = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: {0}", Math.Pow(base1, exponente));
        }
    }
}
