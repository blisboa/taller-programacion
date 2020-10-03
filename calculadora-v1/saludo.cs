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
    public partial class saludo : Form
    {
        public saludo()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombreEstudiante;
            string apellidoEstudiante;
            int matriculaEstudiante;

            nombreEstudiante = txtEstudiante.Text;
            apellidoEstudiante = txtApellido.Text;
            matriculaEstudiante = int.Parse(txtMatricula.Text);
            MessageBox.Show("Hola " + nombreEstudiante + " " + apellidoEstudiante);
        }

        private void saludo_Load(object sender, EventArgs e)
        {

        }
    }
}
