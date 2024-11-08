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
    public partial class FrmRevistas : Form
    {
        private Database database;
        private FrmPrincipal inicio;
        public FrmRevistas(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarRevista frmRevistaAdd = new FrmAgregarRevista(inicio, database);

            frmRevistaAdd.TopLevel = false;
            frmRevistaAdd.FormBorderStyle = FormBorderStyle.None;
            frmRevistaAdd.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frmRevistaAdd);
            frmRevistaAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosRevistas();

            AgregarColumnasPersonalizadas();

            dgvRevistas.DataSource = dt;

            dgvRevistas.DefaultCellStyle.SelectionBackColor = dgvRevistas.BackgroundColor;
            dgvRevistas.DefaultCellStyle.SelectionForeColor = dgvRevistas.ForeColor;

            dgvRevistas.Columns["RevistaID"].Visible = false;
            dgvRevistas.Columns["Nombre"].Width = 200;
            dgvRevistas.Columns["Categoria"].Width = 150;
        }

        private void AgregarColumnasPersonalizadas()
        {
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Name = "btnEditar";
            columnaEditar.HeaderText = "";
            columnaEditar.Image = Properties.Resources.editar16;
            columnaEditar.Width = 50;
            dgvRevistas.Columns.Add(columnaEditar);

            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "btnEliminar";
            columnaEliminar.HeaderText = "";
            columnaEliminar.Image = Properties.Resources.delete16;
            columnaEliminar.Width = 50;
            dgvRevistas.Columns.Add(columnaEliminar);
        }

        private void dgvRevistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvRevistas.Columns["btnEditar"].Index)
                {
                    DataGridViewRow row = dgvRevistas.Rows[e.RowIndex];
                    Revista revistaSeleccionada = database.BuscarRevistaPorID(Convert.ToInt32(row.Cells["RevistaID"].Value));
                    FrmEditarRevista frm = new FrmEditarRevista(inicio, revistaSeleccionada, database);

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    inicio.panelContenedor.Controls.Clear();

                    inicio.panelContenedor.Controls.Add(frm);
                    frm.Show();
                }

                if (e.ColumnIndex == dgvRevistas.Columns["btnEliminar"].Index)
                {
                    DataGridViewRow row = dgvRevistas.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {row.Cells["Nombre"].Value}?",
                                                          "Confirmar eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        database.EliminarRevista(Convert.ToInt32(row.Cells["RevistaID"].Value));
                        dgvRevistas.Rows.RemoveAt(e.RowIndex);
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
