using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            // 1.ubicacion = 286; 85
            // 2.tamaño = 50; 85
            //btnCalcular.Location = new Point(286, 85);
            btnCalcular.Size = new Size(50, 100);
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

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //MessageBox.Show("presiono enter");
                txtNumero2.Focus();
            }
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan, asignado true al Handled
                e.Handled = true;
            }
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_MouseLeave(object sender, EventArgs e)
        {
            // 1.ubicacion = 286; 116
            //2.tamaño = 50; 54
            //btnCalcular.Location = new Point(286, 116);
            btnCalcular.Size = new Size(50, 54);

        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnRestar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestar.Size = new Size(108, 52);
        }

        private void btnRestar_MouseLeave(object sender, EventArgs e)
        {
            btnRestar.Size = new Size(50, 52);
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("usted arrastró algo a esta pantalla.");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
