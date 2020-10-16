using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matematica;

namespace calculadoraWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // definir la variable "calc" de tipo matematica.calculadora
            // definiendo el objeto "calc" que es de tipo clase calculadora
            matematica.calculadora calc;
            // crear el objeto
            calc = new calculadora();


            int numero1, numero2, resultado;
            numero1 = int.Parse(txtOp1.Text);
            numero2 = int.Parse(txtOp2.Text);

            // a la variable resultado le asigamos el valor 
            // que será devuelto por el método Sumar()
            resultado = calc.Sumar(numero1, numero2);

            txtResultado.Text = resultado.ToString();


        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            // definri el objeto "calc"
            matematica.calculadora calc;
            // crear el objeto "calc"

            calc = new calculadora();
            int numero1, numero2, resultado;
            numero1 = int.Parse(txtOp1.Text);
            numero2 = int.Parse(txtOp2.Text);

            // a la variable resultado le asigamos el valor 
            // que será devuelto por el método Restar()
            resultado = calc.Restar(numero1, numero2);

            txtResultado.Text = resultado.ToString();

        }
    }
}
