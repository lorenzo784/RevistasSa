using RevistasSA.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevistasSA
{
    public partial class FrmEntregas : Form
    {
        private Database database;
        private FrmInicio inicio;
        public FrmEntregas(FrmInicio inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEntrega frmEntregaAdd = new FrmAgregarEntrega(database);

            frmEntregaAdd.TopLevel = false;
            frmEntregaAdd.FormBorderStyle = FormBorderStyle.None;
            frmEntregaAdd.Dock = DockStyle.Fill;

            inicio.pContenedor.Controls.Clear();

            inicio.pContenedor.Controls.Add(frmEntregaAdd);
            frmEntregaAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosEntregas();
            dgvEntregas.DataSource = dt;
        }
    }
}
