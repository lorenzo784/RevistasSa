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
    public partial class FrmSuscripciones : Form
    {
        private Database database;
        private FrmPrincipal inicio;
        public FrmSuscripciones(FrmPrincipal inicio, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable dt = database.ObtenerDatosSuscripciones();

            AgregarColumnasPersonalizadas();

            dgvSuscipciones.DataSource = dt;

            dgvSuscipciones.DefaultCellStyle.SelectionBackColor = dgvSuscipciones.BackgroundColor;
            dgvSuscipciones.DefaultCellStyle.SelectionForeColor = dgvSuscipciones.ForeColor;

            dgvSuscipciones.Columns["ID"].Visible = false;
            dgvSuscipciones.Columns["NumeroSuscripcion"].Width = 170;
        }

        private void AgregarColumnasPersonalizadas()
        {
            //DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            //columnaEditar.Name = "btnEditar";
            //columnaEditar.HeaderText = "";
            //columnaEditar.Image = Properties.Resources.editar16;
            //columnaEditar.Width = 50;
            //dgvSuscipciones.Columns.Add(columnaEditar);

            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "btnEliminar";
            columnaEliminar.HeaderText = "";
            columnaEliminar.Image = Properties.Resources.delete16;
            columnaEliminar.Width = 50;
            dgvSuscipciones.Columns.Add(columnaEliminar);
        }

        private void dgvSuscipciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvSuscipciones.Columns["btnEditar"].Index)
                {
                    DataGridViewRow row = dgvSuscipciones.Rows[e.RowIndex];
                    MessageBox.Show($"Se seleccionó editar a {row.Cells["Nombre"].Value}");
                }

                if (e.ColumnIndex == dgvSuscipciones.Columns["btnEliminar"].Index)
                {
                    DataGridViewRow row = dgvSuscipciones.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {row.Cells["ID"].Value}?",
                                                          "Confirmar eliminación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        database.EliminarSuscripcion(Convert.ToInt32(row.Cells["ID"].Value));
                        // Eliminar la fila del DataGridView
                        dgvSuscipciones.Rows.RemoveAt(e.RowIndex);
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
