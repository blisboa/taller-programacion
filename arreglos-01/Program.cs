using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            nota1 = 7;

            int[] notas; // definir un arreglo de enteros
            notas = new int[3]; // creando un arreglo de 3 elementos, dimension 3, o de largo 3

            notas[0] = 4; // asignando al primer elmento, primera celda el numero  4
            notas[1] = 5; // asignando al segundo elmento, segunda celda el numero  5
            notas[2] = 6; // asignando al tercer elmento, tercera celda el numero  6

            //Console.WriteLine(notas[0].ToString());
            //Console.WriteLine(notas[1].ToString());
            //Console.WriteLine(notas[2].ToString());
            Console.WriteLine("Iniciliazra en uno.");
            int contador = 1;
            while (contador <=3) 
            // mientras el valor de la variable "contador" sea menor o igual a 3 haga lo siguient
            {
                Console.WriteLine(notas[contador-1].ToString());
                contador = contador + 1;
            }

            Console.ReadKey();

            Console.WriteLine("Iniciliazra en cero.");
            contador = 0;
            while (contador <= 2)
            // mientras el valor de la variable "contador" sea menor o igual a 3 haga lo siguient
            {
                Console.WriteLine(notas[contador].ToString());
                contador = contador + 1;
            }

            Console.ReadKey();

        }
    }
}
