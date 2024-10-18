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
    public partial class FrmRevistas : Form
    {
        private Database database;
        private FrmInicio inicio;
        public FrmRevistas(FrmInicio inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarRevista frmRevistaAdd = new FrmAgregarRevista(database);

            frmRevistaAdd.TopLevel = false;
            frmRevistaAdd.FormBorderStyle = FormBorderStyle.None;
            frmRevistaAdd.Dock = DockStyle.Fill;

            inicio.pContenedor.Controls.Clear();

            inicio.pContenedor.Controls.Add(frmRevistaAdd);
            frmRevistaAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosRevistas();
            dgvRevistas.DataSource = dt;
        }
    }
}
