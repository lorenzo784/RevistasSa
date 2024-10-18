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
    public partial class FrmAgregarEmpleado : Form
    {
        private Database database;
        public FrmAgregarEmpleado(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;
            database.InsertarEmpleado(nombre, apellido, telefono, direccion);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
        }
    }
}
