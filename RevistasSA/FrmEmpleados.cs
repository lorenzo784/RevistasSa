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
            FrmAgregarEmpleado frmEmpleadoAdd = new FrmAgregarEmpleado(database, inicio);

            frmEmpleadoAdd.TopLevel = false;
            frmEmpleadoAdd.FormBorderStyle = FormBorderStyle.None;
            frmEmpleadoAdd.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frmEmpleadoAdd);
            frmEmpleadoAdd.Show();
        }

        private void CargarDatos()
        {
            // Obtén los datos y asígnalos al DataGridView
            DataTable dt = database.ObtenerDatosEmpleados();

            AgregarColumnasPersonalizadas();

            dgvEmpleados.DataSource = dt;

            dgvEmpleados.DefaultCellStyle.SelectionBackColor = dgvEmpleados.BackgroundColor;
            dgvEmpleados.DefaultCellStyle.SelectionForeColor = dgvEmpleados.ForeColor;

            dgvEmpleados.Columns["EmpleadoID"].Visible = false;
            dgvEmpleados.Columns["Direccion"].Width = 200;
            dgvEmpleados.Columns["Nombre"].Width = 200;
            dgvEmpleados.Columns["Telefono"].Width = 145;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpleados.ClearSelection();
        }


        private void AgregarColumnasPersonalizadas()
        {
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Name = "btnEditar";
            columnaEditar.HeaderText = "";
            columnaEditar.Image = Properties.Resources.editar16;
            columnaEditar.Width = 50;
            dgvEmpleados.Columns.Add(columnaEditar);

            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "btnEliminar";
            columnaEliminar.HeaderText = "";
            columnaEliminar.Image = Properties.Resources.delete16;
            columnaEliminar.Width = 50;
            dgvEmpleados.Columns.Add(columnaEliminar);
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvEmpleados.Columns["btnEditar"].Index)
                {
                    DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                    Empleado empleadoSeleccionado = database.BuscarEmpleadoPorID(Convert.ToInt32(row.Cells["EmpleadoID"].Value));
                    FrmEditarEmpleado frm = new FrmEditarEmpleado(inicio, empleadoSeleccionado, database);

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    inicio.panelContenedor.Controls.Clear();

                    inicio.panelContenedor.Controls.Add(frm);
                    frm.Show();
                }

                if (e.ColumnIndex == dgvEmpleados.Columns["btnEliminar"].Index)
                {
                    DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {row.Cells["Nombre"].Value}?",
                                                          "Confirmar eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        database.EliminarEmpleado(Convert.ToInt32(row.Cells["EmpleadoID"].Value));

                        dgvEmpleados.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        // Si el usuario no confirma, no hacer nada
                        MessageBox.Show("La eliminación fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
