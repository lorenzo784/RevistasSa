using RevistasSA.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevistasSA
{
    public partial class FrmClientes : Form
    {
        private Database database;
        private FrmInicio inicio;
        public FrmClientes(FrmInicio inicio,Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frmClienteAdd = new FrmAgregarCliente(database);

            frmClienteAdd.TopLevel = false;
            frmClienteAdd.FormBorderStyle = FormBorderStyle.None;
            frmClienteAdd.Dock = DockStyle.Fill;

            inicio.pContenedor.Controls.Clear();

            inicio.pContenedor.Controls.Add(frmClienteAdd);
            frmClienteAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosClientes();
            dgvClientes.DataSource = dt;
        }
    }

}
