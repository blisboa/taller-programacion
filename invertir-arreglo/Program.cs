using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertir_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 10, 3, 78, 45, 23, 1 };
            int[] B = new int[5];

            int cntA = 0;
            int cntB = 4;
            while (cntA< 5)
            {
                B[cntB] = A[cntA];
                cntA++;
                cntB--;
            }

            int pos = 0;
            Console.WriteLine("Arreglo A");
            while (pos < 5) {
                Console.WriteLine(A[pos]);
                pos++;
            }

            pos = 0;
            Console.WriteLine("Arreglo B");
            while (pos < 5)
            {
                Console.WriteLine(B[pos]);
                pos++;
            }
            Console.ReadKey();
        }
    }
}
