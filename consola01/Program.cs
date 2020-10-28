using System;


namespace consola01
{
    class Program
    {
        static void Main(string[] args)
        {

			// mostrar por panatlla los priemros 10 numeros ( 1 al 10) en lineas separadas
			int contador1 = 1;
			int contador2 = 1;
			int contador3 = 1;
			while (contador1 <= 9)
			{
				Console.Write("=");
				contador1 = contador1 + 1;
			}
			Console.WriteLine("=");
			while (contador2 <= 5)
			{
				Console.Write("|");
				contador2 = contador2 + 1;
			}
			while (contador3 <= 9)
			{
				Console.Write("=");
				contador3 = contador3 + 1;
			}
			Console.WriteLine("=");
		
		Console.ReadKey();
		}
    }
}
