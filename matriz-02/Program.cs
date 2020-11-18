using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar Matriz de dimension 4x5 (4 filas y 5 columnas)
            int[,] Matriz = new int[4, 5];

            // poblar (asignar valores) la matriz
            // para recorrer una matriz necesitamos "2 instruccicones FOR" 
            // Primer FOR es para recorrer las filas
            // Segundo FOR es para recorrer las columnas
            int fila, col;
            Random aleatorio= new Random() ;
            for (fila = 0; fila < 4; fila++)
                for (col = 0; col < 5; col++)
                    Matriz[fila,col] = aleatorio.Next(1,1000) ;

            // impirmir la matriz
            for (fila = 0; fila < 4; fila++) { 
                for (col = 0; col < 5; col++)
                     //Console.Write( Matriz[fila, col] + " ");
                       Console.Write(Matriz[fila, col].ToString("000") + " ");
                Console.WriteLine(); // imprimir salto de linea 
            }

            Console.ReadKey();
        }
    }
}
