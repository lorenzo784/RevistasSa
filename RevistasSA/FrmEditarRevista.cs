using RevistasSA.Datos;
using RevistasSA.Modelos;
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
    public partial class FrmEditarRevista : Form
    {
        private Revista revista;
        private Database database;
        private FrmPrincipal inicio;
        public FrmEditarRevista(FrmPrincipal inicio, Revista revista, Database database)
        {
            InitializeComponent();
            this.revista = revista;
            this.database = database;
            this.inicio = inicio;
            cargarDatos();
        }

        private void cargarDatos()
        {
            if (revista == null)
            {
                MessageBox.Show("Ocurrió un error. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbNombre.Text = revista.Nombre;
            tbCategoria.Text = revista.Categoria;
            tbPrecio.Text = revista.Precio.ToString();
            tbFrecuencia.Text = revista.Frecuencia;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbCategoria.Text == "" || tbPrecio.Text == "" || tbFrecuencia.Text == "")
            {
                MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = tbNombre.Text;
            string categoria = tbCategoria.Text;
            string precio = tbPrecio.Text;
            string frecuencia = tbFrecuencia.Text;
            database.ModificarRevista(revista.RevistaID, nombre, Convert.ToInt32(precio), categoria, frecuencia);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            FrmRevistas frm = new FrmRevistas(inicio, database);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frm);
            frm.Show();
        }
    }
}
