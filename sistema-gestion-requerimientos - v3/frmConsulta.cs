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

        int RowNo;
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

            string tipoRequerimiento = cmbTipoRequerimiento.SelectedValue.ToString();
            string tipoPrioridad = cmbPrioridad.SelectedValue.ToString();


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
            sqlCmd.Parameters.AddWithValue("@tipoReq", tipoRequerimiento);
            sqlCmd.Parameters.AddWithValue("@tipoPrioridad", tipoPrioridad);

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

            cmbTipoRequerimiento.DisplayMember = "Text";
            cmbTipoRequerimiento.ValueMember = "Value";
            var itemsReq = new[] {
            new { Text = "Instalar Software", Value = "1" },
            new { Text = "Formatear computador", Value = "2" },
            new { Text = "Desbloquear usuario ", Value = "3" },
            };
            cmbTipoRequerimiento.DataSource = itemsReq;

            cmbPrioridad.DisplayMember = "Text";
            cmbPrioridad.ValueMember = "Value";
            var items = new[] {
            new { Text = "Alta", Value = "1" },
            new { Text = "Media", Value = "2" },
            new { Text = "Baja", Value = "3" },
            };
            cmbPrioridad.DataSource = items;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (dgvRequeriminetos.SelectedRows.Count > 0)
            {
                string IdRequerimiento = dgvRequeriminetos.SelectedRows[0].Cells[0].Value.ToString();


                // Aqui nos conectaresmo a la base y validar el usuario y clave
                // establecer la conecion
                string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
                SqlConnection sqlCon = new SqlConnection(cadenaConexion);
                sqlCon.Open();

                // ejecutar llamada al sp que esta en la base de datos
                SqlCommand sqlCmd;

                // exec ValidarUsuario 'blisboa','123456'
                sqlCmd = new SqlCommand("ModificarRequerimiento", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdReq", IdRequerimiento);

                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                DataTable dtData = new DataTable();
                sqlSda.Fill(dtData);

                if (dtData.Rows.Count > 0)
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    btnBuscar.PerformClick();
                }

                //cerrar la conexion a la base datos
                sqlCon.Close();

            }

            //string Value = dgvRequeriminetos.Rows[RowNo].Cells[2].Value.ToString();

            //MessageBox.Show(Value);

            //if (dgvRequeriminetos.SelectedRows.Count > 0)
            //{
            //    string Value = dgvRequeriminetos.SelectedRows[0].Cells[1].Value.ToString();

            //    MessageBox.Show(Value);
            //}
        }

        private void dgvRequeriminetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            RowNo = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {



            if (dgvRequeriminetos.SelectedRows.Count > 0)
            {
                string IdRequerimiento = dgvRequeriminetos.SelectedRows[0].Cells[0].Value.ToString();


                // Aqui nos conectaresmo a la base y validar el usuario y clave
                // establecer la conecion
                string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
                SqlConnection sqlCon = new SqlConnection(cadenaConexion);
                sqlCon.Open();

                // ejecutar llamada al sp que esta en la base de datos
                SqlCommand sqlCmd;

                // exec ValidarUsuario 'blisboa','123456'
                sqlCmd = new SqlCommand("EliminarRequerimiento", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdReq", IdRequerimiento);

                SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
                DataTable dtData = new DataTable();
                sqlSda.Fill(dtData);

                if (dtData.Rows.Count > 0)
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    btnBuscar.PerformClick();
                }

                //cerrar la conexion a la base datos
                sqlCon.Close();

            }

        }
    }
}
