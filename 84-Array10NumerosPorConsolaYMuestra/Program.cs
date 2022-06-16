using System;

//Crea un array de 10 posiciones, pide los valores por consola y muestra el array.

namespace _84_Array10NumerosPorConsolaYMuestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 10 numeros por consola y los mostramos:");

            int[] ingresos = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa el numero de la posicion " + i + ": " + (ingresos[i] = Convert.ToInt32(Console.ReadLine())));
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Los numeros ingresados son: " + ingresos[i]);
            }

            //OTRA OPCION:

            int[] array = new int[10];


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Escribe un numero en la pos " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;

            }

            Console.WriteLine("Mostrar datos");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
