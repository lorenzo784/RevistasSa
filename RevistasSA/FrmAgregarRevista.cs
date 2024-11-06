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
    public partial class FrmAgregarRevista : Form
    {
        private Database database;
        public FrmAgregarRevista(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecio.Text == "" || tbCategoria.Text == "" || tbFrecuencia.Text == "")
            {
                MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = tbNombre.Text;
            string precio = tbPrecio.Text;
            string categoria = tbCategoria.Text;
            string frecuencia = tbFrecuencia.Text;
            database.InsertarEmpleado(nombre, precio, categoria, frecuencia);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbPrecio.Text = "";
            tbCategoria.Text = "";
            tbFrecuencia.Text = "";
        }
    }
}
