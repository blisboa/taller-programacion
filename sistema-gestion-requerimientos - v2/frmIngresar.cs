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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {
            cmbRequerimiento.DisplayMember = "Text";
            cmbRequerimiento.ValueMember = "Value";
            var itemsReq = new[] {
            new { Text = "Instalar Software", Value = "1" },
            new { Text = "Formatear computador", Value = "2" },
            new { Text = "Desbloquear usuario ", Value = "3" },
            };
            cmbRequerimiento.DataSource = itemsReq;
            cmbRequerimiento.SelectedIndex = -1;

            cmbUsuario.DisplayMember = "Text";
            cmbUsuario.ValueMember = "Value";
            var itemsUsuario = new[] {
            new { Text = "blisboa", Value = "1" },
            new { Text = "pperez", Value = "2" },
            new { Text = "pedro", Value = "3" },
            };
            cmbUsuario.DataSource = itemsUsuario;
            cmbUsuario.SelectedIndex = -1;

            cmbPrioridad.DisplayMember = "Text";
            cmbPrioridad.ValueMember = "Value";
            var items = new[] {
            new { Text = "Alta", Value = "1" },
            new { Text = "Media", Value = "2" },
            new { Text = "Baja", Value = "3" },
            };
            cmbPrioridad.DataSource = items;
            cmbPrioridad.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbRequerimiento.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbPrioridad.SelectedIndex = -1;
            txtDescripcion.Text = "";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmConsulta frmCon = new frmConsulta();
            frmCon.Tag = this.Tag; // pasando el usuairo conectado al fromulario de Consulta
            frmCon.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Aqui nos conectaresmo a la base y validar el usuario y clave
            // establecer la conecion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // capturar los valores selecionados en los combobox e ingresado en la caja de texto
            string tipoReq = cmbRequerimiento.SelectedValue.ToString();
            string idUsuario = cmbUsuario.SelectedValue.ToString();
            string descripcion = txtDescripcion.Text;
            string tipoPrioridad= cmbPrioridad.SelectedValue.ToString();


            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("IngresarRequerimiento", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq", tipoReq);
            sqlCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            sqlCmd.Parameters.AddWithValue("@descripcion", descripcion);
            sqlCmd.Parameters.AddWithValue("@tipoPrioridad", tipoPrioridad);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
            }

                //cerrar la conexion a la base datos
                sqlCon.Close();

        }
    }
}
