using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_01
{
    public partial class login : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ValidarUsuario( string Usuario, String Clave)
        {
            // stringConexion
            string cadenaconexion = "Server=SCLNTB6610290,1433;Database=reqv1;User Id=sa;Password=Sonda.2020;";

            con = new SqlConnection(cadenaconexion);
            con.Open();

            // invocar al SP
            cmd = new SqlCommand("ValidarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nickName", Usuario);
            cmd.Parameters.AddWithValue("@password", Clave);
            
            string ret = "";
            // Ejecutar la llamada al SP
            dr = cmd.ExecuteReader();

            // Preguntar si el SP devolvio algun registro
            if (dr.Read())
            {
                ret = dr.GetValue(0).ToString();

                if (ret == "UsuarioOk")
                {
                    MessageBox.Show("Acceso permitido");
                }
                else
                {
                    MessageBox.Show("Acceso denegado");
                    //MessageBox.Show(dr.GetValue(1).ToString());
                }

            }
            else
                MessageBox.Show("Problemas al validar, acceso denegado");

            con.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtUsuario.Text, txtPassword.Text);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
