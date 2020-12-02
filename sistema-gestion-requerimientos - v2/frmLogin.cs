using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace sistema_gestion_requerimientos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            // Aqui nos conectaresmo a la base y validar el usuario y clave
            // establecer la conecion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("ValidarUsuario", sqlCon);
           sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@nickName", txtUsuario.Text);
            sqlCmd.Parameters.AddWithValue("@password", txtClave.Text);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // Validar si el usuario tiene o no tiene al Sistema
            if (dtData.Rows.Count > 0)
            {

                // dataGridView1.DataSource = dtData;
                // Si en el campo CodigoRet viene el valor 0, siginifica que el usuario/clave son correctos
                if (Convert.ToInt32(dtData.Rows[0]["CodigoRet"]) == 0)
                {
                    //MessageBox.Show( Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                    // Mostrar la pantalla con las opciones de menu
                    this.Hide();
                    Form frmMenu = new frmMenuPrincipal();
                    frmMenu.Tag = txtUsuario.Text;
                    frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show(Convert.ToString(dtData.Rows[0]["MensajeRet"]));
                }
            }
            else
                MessageBox.Show("No fue posible validar al usuario, se niega el acceso");

            //cerrar la conexion a la base datos
            sqlCon.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {            
            // Operador de negacion NOT es el caracter !
            txtClave.UseSystemPasswordChar = ! txtClave.UseSystemPasswordChar;
            if (txtClave.UseSystemPasswordChar == true)
                btnVer.Text = "Ver";
            else
                btnVer.Text = "Ocultar";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
