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
            // manejo o control de errores
           try { // estas intrucciones se intenta ejecutar
                int Numero1, Numero2, Resultado;           
                Numero1 = int.Parse(txtNumero1.Text);
                Numero2 = int.Parse(txtNumero2.Text);            
                Resultado = Numero1 + Numero2;
                txtResultado.Text = Resultado.ToString();
            }
            catch (Exception errorAtrapado) // esta parte del codigo atrapa los errores durante la ejecucion
            {
                MessageBox.Show("Estimado usuario se produjo el siguiente error" + errorAtrapado.Message);
                txtNumero1.Text = ""; // limpiando la caja de texto txtNumero1
            }


        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            // aqui se van a ejcutar las intrucciones se se van a ejecutar cuando
            // se hace un CLICK en el boton llamado btnRestar

            // se definen 3 variables de tipo entero
            try { 
                int Numero1, Numero2, Resultado;

                // ahora vamos a LEER los dos numeros ingresado por pantalla
                Numero1 = int.Parse(txtNumero1.Text);
                Numero2 = int.Parse(txtNumero2.Text);

                // aqui estamos sumando 2 numeros enteros 
                // y lo asignamos a la variable Resultado que tambien es un entero
                Resultado = Numero1 - Numero2;
                if (Resultado > 1)
                    MessageBox.Show("Hay " + Resultado.ToString() + "gatitos.");
                else
                    MessageBox.Show("Hay " + Resultado.ToString() + "gatito.");
                // aqui vamos a mostrar la suma en la caja de texto txtResultado
                // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
                txtResultado.Text = Resultado.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Estimado usuario se ha producido el siguiente error:" + error.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aqui escribo las intrucciones que quiero que se ejecuten
            // cuando se presione una tecla en la caja de texto txtNumero1
           /// MessageBox.Show("usted presiono una tecla");
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aqui escribo las intrucciones que se se van a ejcutar cunado se 
            // se presiones una tecal en la caja de texto txtNumero2
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int Numero1, Numero2, Resultado;

                // ahora vamos a LEER los dos numeros ingresado por pantalla
                Numero1 = int.Parse(txtNumero1.Text);
                Numero2 = int.Parse(txtNumero2.Text);

                // aqui estamos sumando 2 numeros enteros 
                // y lo asignamos a la variable Resultado que tambien es un entero
                // Validar que numero2 no sea cero
                if (Numero2 == 0)
                    MessageBox.Show("El nuemro 2 no puede ser cero en la divison");
                else { 
                    Resultado = Numero1 / Numero2;
                    if (Resultado > 1)
                        MessageBox.Show("Hay " + Resultado.ToString() + "gatitos.");
                    else
                        MessageBox.Show("Hay " + Resultado.ToString() + "gatito.");
                    // aqui vamos a mostrar la suma en la caja de texto txtResultado
                    // El metodo ToString() nos permite convertir a string el contenido de uan variable diferente a strin (numeros)
                    txtResultado.Text = Resultado.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Estimado usuario se ha producido el siguiente error: " + error.Message);

            }
        }
    }
}
