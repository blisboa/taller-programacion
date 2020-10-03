using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora03
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           // se definen 3 variables de tipo entero
            int Numero1, Numero2, Resultado;

            // ahora vamos a LEER los dos numeros ingresado por pantalla
            Numero1 = int.Parse(txtNumero1.Text);
            Numero2 = int.Parse(txtNumero2.Text);

            // aqui estamos sumando 2 numeros enteros 
            // y lo asignamos a la variable Resultado que tambien es un entero
            Resultado = Numero1 + Numero2;

            // aqui vamos a mostrar la suma en la caja de texto txtResultado
            // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
            txtResultado.Text = Resultado.ToString();
        }

        private void calculadora_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnCalcular_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            // se definen 3 variables de tipo entero
            int Numero1, Numero2, Resultado;

            // ahora vamos a LEER los dos numeros ingresado por pantalla
            Numero1 = int.Parse(txtNumero1.Text);
            Numero2 = int.Parse(txtNumero2.Text);

            // aqui estamos sumando 2 numeros enteros 
            // y lo asignamos a la variable Resultado que tambien es un entero
            Resultado = Numero1 - Numero2;

            // aqui vamos a mostrar la suma en la caja de texto txtResultado
            // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
            txtResultado.Text = Resultado.ToString();
        }

        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se definen 3 variables de tipo entero
            int Numero1, Numero2, Resultado;

            // ahora vamos a LEER los dos numeros ingresado por pantalla
            Numero1 = int.Parse(txtNumero1.Text);
            Numero2 = int.Parse(txtNumero2.Text);

            // aqui estamos sumando 2 numeros enteros 
            // y lo asignamos a la variable Resultado que tambien es un entero
            Resultado = Numero1 * Numero2;

            // aqui vamos a mostrar la suma en la caja de texto txtResultado
            // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
            txtResultado.Text = Resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // se definen 3 variables de tipo entero
            int Numero1, Numero2, Resultado;

            // ahora vamos a LEER los dos numeros ingresado por pantalla
            Numero1 = int.Parse(txtNumero1.Text);
            Numero2 = int.Parse(txtNumero2.Text);

            // aqui estamos sumando 2 numeros enteros 
            // y lo asignamos a la variable Resultado que tambien es un entero
            Resultado = Numero1 / Numero2;

            // aqui vamos a mostrar la suma en la caja de texto txtResultado
            // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
            txtResultado.Text = Resultado.ToString();
        }
    }
}
