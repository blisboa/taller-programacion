using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqueda_rapida
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dias_esp = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            string[] dias_ingles = { "Monday", "Thuesday", "Wensday", "Thuersday", "Friday", "Saturday", "Sunday" };
            string[] meses_esp= { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };
            string[] meses_ingles = { "January", "February", "March", "April", "May", "June", "July", "Aguts", "September", "October", "November", "December" };

            // dada un dia en español mostraremo el dia en ingles

            string dia = "Domingo";
            int pos_dia = 0;
            for(int pos= 0; pos <=6; pos++)
            {
                if(dias_esp[pos] == dia)
                {
                    pos_dia = pos;
                }
            }

            Console.WriteLine("El dia " + dia + " en ingles se escribe:" + dias_ingles[pos_dia]);


            string mes= "Enero";
            int pos_mes = 0;
            for (int pos = 0; pos <= 6; pos++)
            {
                if (meses_esp[pos] == mes)
                {
                    pos_mes = pos;
                }
            }

            Console.WriteLine("El mes " + mes + " en ingles se escribe:" + meses_ingles[pos_mes]);

            Console.ReadKey();
        }
    }
}
