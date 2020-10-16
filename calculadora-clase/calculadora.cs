using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica
{
    public class calculadora
    {


        // metodo Sumar : recibir 2 numeros y devolverá la suma de esos numeros
        // ambito desde donde o quien puede utilizar este metodo: public
        // el tipo de dato de la variable retonar: int
        // nombre del metodo: Sumar
        // paraámetros del método: (tipo de dato ,nombre del parametro)
        //                           int operando1
        //                           int operando2

        public int Sumar(int operando1, int operando2)
        {
           return operando1+ operando2;
        }

        public int Restar(int operando1, int operando2)
        {
            return operando1 - operando2;
        }

    }
}
