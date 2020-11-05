using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas; // definiendo el arrelo
            notas = new int[5]; // crear el arreglo de 5 elemento

            // asignar al primer elemnto el numero 5
            // debemso utilizar el indice 0 (posicion 0)
            notas[0] = 5;
            notas[1] = 3;
            notas[2] = 3;
            notas[3] = 5;
            notas[4] = 6;

            int promedio;

            // primera idea, soluicion:
            int suma;
            suma = notas[0] + notas[1] + notas[2] + notas[3] + notas[4];
            promedio = suma / 5;

            //utilizar ciclo : while, for , do while
            int posicion = 0;
            suma = 0;
            while (posicion < 5)
            {
                suma = suma + notas[posicion];
                posicion = posicion + 1;
            }
            promedio = suma / 5;

            Console.Write("La suma es :" + suma.ToString());
            Console.Write("Promedio es :" + promedio.ToString());

            Console.ReadKey();
        }
    }
}
