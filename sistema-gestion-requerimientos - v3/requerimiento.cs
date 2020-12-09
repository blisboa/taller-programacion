using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistema_gestion_requerimientos
{
    class requerimiento
    {
        // el metodo constructor de la clase
        public requerimiento()
        {
            TipoRequerimiento = "";
            IdentificadorUsuario = "";
            TipoPrioridad = "";
            Descripcion = "";

        }
        public string TipoRequerimiento { get; set; }
        public string  IdentificadorUsuario { get; set; }
        public string TipoPrioridad { get; set; }
        public string Descripcion { get; set; }

        public int Error { get; set; }
        public string  Mensaje { get; set; }

        public void Grabar()
        {

            string MensajeRetorno = "";
            // Aqui nos conectaresmo a la base y validar el usuario y clave
            // establecer la conecion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = reqv1; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("IngresarRequerimiento", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq", TipoRequerimiento);
            sqlCmd.Parameters.AddWithValue("@IdUsuario", IdentificadorUsuario);
            sqlCmd.Parameters.AddWithValue("@descripcion", Descripcion);
            sqlCmd.Parameters.AddWithValue("@tipoPrioridad", TipoPrioridad);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            Error = 1;
            if (dtData.Rows.Count > 0)
            {
                Error = 0;
                Mensaje = Convert.ToString(dtData.Rows[0]["MensajeRet"]);
            }

            //cerrar la conexion a la base datos
            sqlCon.Close();

        }

    }
}
