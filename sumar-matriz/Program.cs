using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumar_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar 3 matrices de dimension 5x5 ( 5 filas y 5 columnas)
            int[,] M1 = new int[5, 5];
            int[,] M2 = new int[5, 5];
            int[,] M3 = new int[5, 5];

            int fila, col;
            //  M1.GetLength(0) nos entrega la cantidad de filas de la matriz M1
            //  M1.GetLength(1) nos entrega la cantidad de columnas de la matriz M1

            Random aleatorio = new Random(); 

            // Recorriendo la matriz y asignando valores aleatorios a cada elemento
            for (fila = 0; fila < M1.GetLength(0); fila++)
            {
                for(col = 0; col < M1.GetLength(1); col++)
                {
                    M1[fila, col] = aleatorio.Next(1, 100);
                    M2[fila, col] = aleatorio.Next(1, 100);
                }
            }


            // imprimir el contenido de M1
            Console.WriteLine("Matriz 1:");
            for (fila = 0; fila < M1.GetLength(0); fila ++)
            {
                for ( col = 0; col < M1.GetLength(1); col++)
                {
                    Console.Write(M1[fila, col].ToString("00") + " ");
                }
                Console.WriteLine();
            }


            // imprimir el contenido de M2
            Console.WriteLine("Matriz 2:");
            for (fila = 0; fila < M2.GetLength(0); fila++)
            {
                for (col = 0; col < M2.GetLength(1); col++)
                {
                    Console.Write(M2[fila, col].ToString("00") + " ");
                }
                Console.WriteLine();
            }


            // Sumar Matrice, M3 = M1 + M2
            for(fila = 0; fila < M3.GetLength(0); fila++)
            {
                for( col = 0; col < M3.GetLength(1); col++)
                {
                    M3[fila, col] = M1[fila, col] +  M2[fila,col];
                }
            }

            // imprimir el contenido de M3
            Console.WriteLine("Matriz 1 + Matriz 2:");
            for (fila = 0; fila < M3.GetLength(0); fila++)
            {
                for (col = 0; col < M3.GetLength(1); col++)
                {
                    Console.Write(M3[fila, col].ToString("000") + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
