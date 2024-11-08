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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevistasSA
{
    public partial class FrmAgregarCliente : Form
    {
        Database database;
        private FrmPrincipal inicio;
        public FrmAgregarCliente(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "" || tbNit.Text == "")
            {
                MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;
            string nit = tbNit.Text;
            database.InsertarCliente(nombre, apellido, direccion, telefono, nit);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
            mostrarDatos();
        }

        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            tbNit.Text = "";
        }

        private void mostrarDatos()
        {
            FrmClientes frm = new FrmClientes(inicio, database);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
