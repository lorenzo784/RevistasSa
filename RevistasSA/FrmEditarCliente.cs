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
    public partial class FrmEditarCliente : Form
    {
        private Cliente cliente;
        private Database database;
        private FrmPrincipal inicio;
        public FrmEditarCliente(FrmPrincipal inicio, Cliente cliente, Database database)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.database = database;
            this.inicio = inicio;
            cargarDatos();
        }

        private void cargarDatos()
        {
            if (cliente == null)
            {
                MessageBox.Show("Ocurrió un error. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbNombre.Text = cliente.Nombre;
            tbApellido.Text = cliente.Apellido;
            tbNit.Text = cliente.Nit;
            tbDireccion.Text = cliente.Direccion;
            tbTelefono.Text = cliente.Telefono;
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
            database.ModificarCliente(cliente.ClienteID, nombre, apellido, direccion, telefono, nit);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrarDatos();
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
