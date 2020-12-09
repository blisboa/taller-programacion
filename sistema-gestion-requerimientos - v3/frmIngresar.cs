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
            // definir el objeto Req de la clase requerimiento
            requerimiento Req = new requerimiento();

            // ya no usamos las variables individuales, sino que usamos el objeto Req y sus propiedades
            Req.TipoRequerimiento = cmbRequerimiento.SelectedValue.ToString();      
            Req.IdentificadorUsuario   = cmbUsuario.SelectedValue.ToString();
            Req.Descripcion  = txtDescripcion.Text;
            Req.TipoPrioridad = cmbPrioridad.SelectedValue.ToString();

            Req.Grabar();
            if (Req.Error == 0)
                MessageBox.Show(Req.Mensaje);
        }
    }
}
