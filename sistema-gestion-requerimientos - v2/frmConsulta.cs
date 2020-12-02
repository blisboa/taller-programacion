using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sistema_gestion_requerimientos
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string EstadoSeleccionado;
            // Determnar si se selecicon Pendiente o Resuelto
            if (rbtPendiente.Checked == true)
                EstadoSeleccionado = "P"; 
            else // significa que esta seleccionado el radio buton Resuelto
                EstadoSeleccionado = "R";


            // Aqui nos conectaresmo a la base y validar el usuario y clave
            // establecer la conecion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("ConsultarRequerimientos", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@NickUsuario", txtUsuario.Text);
            sqlCmd.Parameters.AddWithValue("@estado", EstadoSeleccionado);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // mostrar la tabla (resultado del la ejecucion del procedimiento almacendado) en la grilla
            dgvRequeriminetos.DataSource = dtData;

            //cerrar la conexion a la base datos
            sqlCon.Close();

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = this.Tag.ToString(); // En la variable TAG tenemso almacenado el usuario conectados

            // agregar opcines al combox de tipos de requerimientos
            cmbTipoRequerimiento.Items.Insert(0, "Base de datos");
            cmbTipoRequerimiento.Items.Insert(1, "Sistemas");
            cmbTipoRequerimiento.Items.Insert(2, "Servidores");

            // agregar opcines al combox de Prioridades
            cmbPrioridad.Items.Insert(0, "Alta");
            cmbPrioridad.Items.Insert(1, "Media");
            cmbPrioridad.Items.Insert(2, "Baja");
            

        }
    }
}
