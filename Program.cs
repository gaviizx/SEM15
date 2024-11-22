using System;

namespace SEM15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese # filas: ");
            int f  = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # columnas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            Random rand = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(30, 51);
                    Console.Write(matriz[i, j]+"\t");
                }
                Console.WriteLine();
                                 
            }
            Console.ReadKey();
        }
    }
}
