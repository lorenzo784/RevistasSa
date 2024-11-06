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
    public partial class FrmEmpleados : Form
    {
        private Database database;
        private FrmPrincipal inicio;
        public FrmEmpleados(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frmEmpleadoAdd = new FrmAgregarEmpleado(database);

            frmEmpleadoAdd.TopLevel = false;
            frmEmpleadoAdd.FormBorderStyle = FormBorderStyle.None;
            frmEmpleadoAdd.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frmEmpleadoAdd);
            frmEmpleadoAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosEmpleados();
            dgvEmpleados.DataSource = dt;
            dgvEmpleados.Columns["Direccion"].Width = 170;
            dgvEmpleados.Columns["Nombre"].Width = 170;
        }
    }
}
