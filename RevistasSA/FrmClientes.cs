using RevistasSA.Datos;
using RevistasSA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevistasSA
{
    public partial class FrmClientes : Form
    {
        private Database database;
        private FrmPrincipal inicio;

        public FrmClientes(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.database = database;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frmClienteAdd = new FrmAgregarCliente(inicio, database);

            frmClienteAdd.TopLevel = false;
            frmClienteAdd.FormBorderStyle = FormBorderStyle.None;
            frmClienteAdd.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frmClienteAdd);
            frmClienteAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosClientes();

            AgregarColumnasPersonalizadas();

            dgvClientes.DataSource = dt;

            dgvClientes.DefaultCellStyle.SelectionBackColor = dgvClientes.BackgroundColor;
            dgvClientes.DefaultCellStyle.SelectionForeColor = dgvClientes.ForeColor;

            dgvClientes.Columns["ClienteID"].Visible = false;
            dgvClientes.Columns["Direccion"].Width = 170;
            dgvClientes.Columns["Nombre"].Width = 170;
        }


        private void AgregarColumnasPersonalizadas()
        {
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Name = "btnEditar";
            columnaEditar.HeaderText = "";
            columnaEditar.Image = Properties.Resources.editar16;
            columnaEditar.Width = 50;
            dgvClientes.Columns.Add(columnaEditar);

            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "btnEliminar";
            columnaEliminar.HeaderText = "";
            columnaEliminar.Image = Properties.Resources.delete16;
            columnaEliminar.Width = 50;
            dgvClientes.Columns.Add(columnaEliminar);
        }


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvClientes.Columns["btnEditar"].Index)
                {
                    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                    Cliente clienteSelecionado = database.BuscarClientePorID(Convert.ToInt32(row.Cells["ClienteID"].Value));
                    FrmEditarCliente frm = new FrmEditarCliente(inicio, clienteSelecionado, database);

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    inicio.panelContenedor.Controls.Clear();

                    inicio.panelContenedor.Controls.Add(frm);
                    frm.Show();
                }

                if (e.ColumnIndex == dgvClientes.Columns["btnEliminar"].Index)
                {
                    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {row.Cells["Nombre"].Value}?",
                                                          "Confirmar eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        database.EliminarCliente(Convert.ToInt32(row.Cells["ClienteID"].Value));

                        dgvClientes.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("La eliminación fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }

}
