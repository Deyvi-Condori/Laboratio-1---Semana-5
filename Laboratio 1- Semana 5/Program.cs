using System;

namespace MultiSinMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            int limite = numero2;

            if (numero2 < 0)
            {
                limite = -numero2;
            }

            for (int i = 0; i < limite; i++)
            {
                resultado += numero1;
            }

            if ((numero1 < 0) ^ (numero2 < 0)) 
            {
                resultado = -resultado;
            }

            Console.WriteLine($"El producto es {resultado}");
            Console.ReadKey();
        }
    }
}