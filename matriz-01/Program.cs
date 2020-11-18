using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar una varaible llamada M que alamcenara una matriz 2 (filas)x3(cols) de numeros enters
            int[,] M = new int[2, 3];

            // asignar valores a ma matriz
            // asignar valores a la primera fila --> posicion 0
            M[0, 0] = 10; // primera fila y primera columna
            M[0, 1] = 20; // primera fila y segunda columna
            M[0, 2] = 30; // primera fila y tercera columna

            // asignar valores a la segunda fila --> posicion 1
            M[1, 0] = 100;// segunda fila y primera columna
            M[1, 1] = 200;// segunda fila y segunda columna
            M[1, 2] = 300; // segunda fila y tercera columna


            // imprimir en pantalla todos los elementos de la matriz
            int fila, col;

            // permite recorrer todas las fila
            for (fila = 0; fila <=1; fila++)
            {
                // permite recorre todas las columnas
                for (col = 0; col <= 2; col++)
                    // imprime el elemento de la matriz
                    Console.Write(M[fila, col] + " ");
                // imprime un salto de linea para comenzar a imprimir la siguiente fila
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
