using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arreglo; // defino el arreglo
            // arreglo = new int[5]; // creando el arreglo de 5 elementos 

            int[] arreglo = new int[5]; // definir y crear el arreglo de 5 elementos 
            int menorValor = 0;
            arreglo[0] = 5; // asignado el valor 5 al 1er elemento del arreglo ( la primera posicion)
            arreglo[1] = 4;
            arreglo[2] = 0;
            arreglo[3] = -1;
            arreglo[4] = 3;// asignado el valor 3 al 5to elemento del arreglo ( la ultima posicion)

            Console.WriteLine("Priemr While");
            int posicion = 1;
            while (posicion <= 5)  // ciclo que repeterira 5 veces las instrucciones dentro del While
            {
                Console.WriteLine(arreglo[posicion - 1]);
                posicion++; // recordar que seimpre tenemos que incrementar el contador para evitar loop infinito
                // como hacer falsa la condicion del while: (posicion < 5)
            }


            Console.WriteLine("Segundo While");
            posicion = 0;
            menorValor = arreglo[0]; // por defecto inicializamos com MenirValor al 1er elemento del arreglo
            while (posicion < 4)  // ciclo que repeterira 5 veces las instrucciones dentro del While
            {             
                // Comparar el menorValor con los elementos del arreglo y deterianr cual es menor
                if (menorValor > arreglo[posicion + 1])
                    menorValor = arreglo[posicion + 1];
                posicion++; 
            }
            Console.WriteLine("El menor elemento es :" + menorValor.ToString());

            Console.WriteLine("Tercer While");
            posicion = 1300;
            while (posicion < 1305)  // ciclo que repeterira 5 veces las instrucciones dentro del While
            {
                Console.WriteLine(arreglo[posicion-1300]);
                posicion++; // recordar que seimpre tenemos que incrementar el contador para evitar loop infinito
                // como hacer falsa la condicion del while: (posicion < 5)
            }
            Console.ReadKey();
            // arreglo[1300]
        }
    }
}
