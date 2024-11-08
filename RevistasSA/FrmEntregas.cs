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
    public partial class FrmEntregas : Form
    {
        private Database database;
        private FrmPrincipal inicio;
        public FrmEntregas(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEntrega frmEntregaAdd = new FrmAgregarEntrega(database, inicio);

            frmEntregaAdd.TopLevel = false;
            frmEntregaAdd.FormBorderStyle = FormBorderStyle.None;
            frmEntregaAdd.Dock = DockStyle.Fill;

            inicio.panelContenedor.Controls.Clear();

            inicio.panelContenedor.Controls.Add(frmEntregaAdd);
            frmEntregaAdd.Show();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosEntregas();

            AgregarColumnasPersonalizadas();

            dgvEntregas.DataSource = dt;

            dgvEntregas.DefaultCellStyle.SelectionBackColor = dgvEntregas.BackgroundColor;
            dgvEntregas.DefaultCellStyle.SelectionForeColor = dgvEntregas.ForeColor;

            dgvEntregas.Columns["ID"].Visible = false;
            dgvEntregas.Columns["Observaciones"].Width = 170;
        }

        private void AgregarColumnasPersonalizadas()
        {
            //DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            //columnaEditar.Name = "btnEditar";
            //columnaEditar.HeaderText = "";
            //columnaEditar.Image = Properties.Resources.editar16;
            //columnaEditar.Width = 50;
            //dgvEntregas.Columns.Add(columnaEditar);

            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "btnEliminar";
            columnaEliminar.HeaderText = "";
            columnaEliminar.Image = Properties.Resources.delete16;
            columnaEliminar.Width = 50;
            dgvEntregas.Columns.Add(columnaEliminar);
        }

        private void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvEntregas.Columns["btnEditar"].Index)
                {
                    DataGridViewRow row = dgvEntregas.Rows[e.RowIndex];
                    MessageBox.Show($"Se seleccionó editar a {row.Cells["Nombre"].Value}");
                }

                if (e.ColumnIndex == dgvEntregas.Columns["btnEliminar"].Index)
                {
                    DataGridViewRow row = dgvEntregas.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {row.Cells["ID"].Value}?",
                                                          "Confirmar eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        database.EliminarEntrega(Convert.ToInt32(row.Cells["ID"].Value));

                        dgvEntregas.Rows.RemoveAt(e.RowIndex);
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
