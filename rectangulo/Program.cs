using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string horizontal = "X";
            string vertical = "!";
            string relleno = ".";

            // imprimir el techo del rectangulo
            int contador = 1;
            while (contador <= 10)
            {
                Console.Write(horizontal);
                contador++; // es lo mismo que contador = contador + 1
            }
            Console.WriteLine("");// Salto de linea

            int contadorLineas = 1;
            while (contadorLineas <= 5)
            {
                // imprimir una sola linea
                Console.Write(vertical);
                contador = 1;
                while (contador <= 8)
                {
                    Console.Write(relleno);
                    contador = contador + 1;
                }
                Console.WriteLine(vertical);

                contadorLineas = contadorLineas + 1;
            }

            // imprimir el piso del rectangulo
            contador = 1;
            while (contador <= 10)
            {
                Console.Write(horizontal);
                contador++; // es lo mismo que contador = contador + 1
            }
            Console.WriteLine("");// Salto de linea
            Console.ReadKey(); // para evitar que se cierre la consola automaticamente

        }
    }
}
