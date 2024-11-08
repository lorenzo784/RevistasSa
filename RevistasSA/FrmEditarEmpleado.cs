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
    public partial class FrmEditarEmpleado : Form
    {
        private Empleado empleado;
        private Database database;
        private FrmPrincipal inicio;
        public FrmEditarEmpleado(FrmPrincipal inicio, Empleado empleado, Database database)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.database = database;
            this.inicio = inicio;
            cargarDatos();
        }

        private void cargarDatos()
        {
            if (empleado == null)
            {
                MessageBox.Show("Ocurrió un error. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbNombre.Text = empleado.Nombre;
            tbApellido.Text = empleado.Apellido;
            tbDireccion.Text = empleado.Direccion;
            tbTelefono.Text = empleado.Telefono;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;
            database.ModificarEmpleado(empleado.EmpleadoID, nombre, apellido, telefono,direccion);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mostrarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            FrmEmpleados frm = new FrmEmpleados(inicio, database);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frm);
            frm.Show();
        }
    }
}
