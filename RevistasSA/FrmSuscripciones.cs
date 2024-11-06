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
    public partial class FrmSuscripciones : Form
    {
        private Database database;
        private FrmPrincipal inicio;
        public FrmSuscripciones(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosSuscripciones();
            dgvSuscipciones.DataSource = dt;
            dgvSuscipciones.Columns["NumeroSuscripcion"].Width = 170;
        }
    }
}
