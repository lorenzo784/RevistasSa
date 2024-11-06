using RevistasSA.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevistasSA
{
    public partial class FrmAgregarEntrega : Form
    {
        private Database database;

        public FrmAgregarEntrega(Database database)
        {
            InitializeComponent();
            this.database = database;
            int ultimaSuscripcion = database.ObtenerUltimaSuscripcion();
            lbNoSuscripcion.Text = (ultimaSuscripcion + 1).ToString();
            lbFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private int clienteId = 0;
        private int revistaId = 0;
        private int empleadoId = 0;

        private void tbBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ObtenerDatosClientes();
            dataGridView1.Columns["ClienteID"].Visible = false;
            dataGridView1.Columns["Direccion"].Visible = false;
            dataGridView1.Columns["Telefono"].Visible = false;
            dataGridView1.Columns["Nombre"].Width = 140;
            dataGridView1.Height = 90;

            if (tbBuscarCliente.Text.Length >= 2)
            {

                var dt = database.BuscarCliente(tbBuscarCliente.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["ClienteID"].Visible = false;
                    dataGridView1.Columns["Direccion"].Visible = false;
                    dataGridView1.Columns["Telefono"].Visible = false;

                    dataGridView1.Columns["Nombre"].Width = 140;
                    dataGridView1.Height = dataGridView1.Rows.Count * 50;
                }
                else
                {
                    dataGridView1.Height = 0;
                }

            }
            else if (tbBuscarCliente.TextLength <= 0)
            {
                lbDireccion.Text = "";
                lbNit.Text = "";
                lbTelefono.Text = "";
                dataGridView1.DataSource = database.ObtenerDatosClientes();
                dataGridView1.Columns["ClienteID"].Visible = false;
                dataGridView1.Columns["Direccion"].Visible = false;
                dataGridView1.Columns["Telefono"].Visible = false;
                dataGridView1.Columns["Nombre"].Width = 140;
                dataGridView1.Height = 90;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
            clienteId = int.Parse(filaSeleccionada.Cells["ClienteID"].Value.ToString());
            lbDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
            lbNit.Text = filaSeleccionada.Cells["Nit"].Value.ToString();
            lbTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            tbBuscarCliente.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dataGridView1.Height = 0;
        }

        private void cargarDatos()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = DateTime.Now.ToString("yyyy-MM-dd");
            lbFecha.Text = fechaFormateada;
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.ObtenerDatosClientes();
            dataGridView1.Columns["ClienteId"].Visible = false;
            dataGridView1.Columns["Direccion"].Visible = false;
            dataGridView1.Columns["Telefono"].Visible = false;
            dataGridView1.Columns["Nombre"].Width = 140;
            dataGridView1.Height = 90;
        }

        private void tbBuscarRevista_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = database.ObtenerDatosRevistas();
            dataGridView2.Columns["RevistaID"].Visible = false;
            dataGridView2.Columns["Precio"].Visible = false;
            dataGridView2.Columns["Categoria"].Visible = false;
            dataGridView2.Columns["Frecuencia"].Visible = false;
            dataGridView2.Columns["Nombre"].Width = 240;
            dataGridView2.Height = 90;
            if (tbBuscarRevista.Text.Length >= 2)
            {
                var dt = database.BuscarRevistas(tbBuscarRevista.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;

                    dataGridView2.Columns["Nombre"].Width = 240;
                    dataGridView2.Columns["RevistaID"].Visible = false;
                    dataGridView2.Height = dataGridView2.Rows.Count * 50;
                }
                else
                {
                    dataGridView1.Height = 0;
                }

            }
            else if (tbBuscarRevista.TextLength <= 0)
            {
                dataGridView2.DataSource = database.ObtenerDatosRevistas();
                dataGridView2.Columns["RevistaID"].Visible = false;
                dataGridView2.Columns["Precio"].Visible = false;
                dataGridView2.Columns["Categoria"].Visible = false;
                dataGridView2.Columns["Frecuencia"].Visible = false;
                dataGridView2.Columns["Nombre"].Width = 240;
                dataGridView2.Height = 90;
            }
        }

        private void tbBuscarRevista_Enter(object sender, EventArgs e)
        {
            dataGridView2.DataSource = database.ObtenerDatosRevistas();
            dataGridView2.Columns["RevistaID"].Visible = false;
            dataGridView2.Columns["Precio"].Visible = false;
            dataGridView2.Columns["Categoria"].Visible = false;
            dataGridView2.Columns["Frecuencia"].Visible = false;
            dataGridView2.Columns["Nombre"].Width = 240;
            dataGridView2.Height = 90;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView2.Rows[e.RowIndex];
            revistaId = int.Parse(filaSeleccionada.Cells["RevistaID"].Value.ToString());
            tbBuscarRevista.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dataGridView2.Height = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (clienteId == 0 || revistaId == 0 || empleadoId == 0 || tbDireccionEntrega.Text == "")
            {
                MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long segundos = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            int numeroUnico = (int)(segundos % 1000);
            string numeroUnicoString = numeroUnico.ToString("D3");

            numeroUnicoString = $"SUS{numeroUnicoString}";
            var fechaInicio = dtFechaInicio.Value;
            var fechaFin = dtFechaFinalizacion.Value;
            var fechaActual = DateTime.Now;
            database.InsertarSuscripcion(clienteId, revistaId, fechaInicio, fechaFin, numeroUnicoString);
            int suscripcionId = database.ObtenerUltimaSuscripcion();
            database.InsertarEntrega(suscripcionId, empleadoId, fechaActual, fechaActual, tbDireccionEntrega.Text, lbTelefono.Text, "Primera entrega");
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbBuscarCliente.Text = "";
            tbBuscarRevista.Text = "";
            tbDireccionEntrega.Text = "";
            lbTelefono.Text = "";
            lbNit.Text = "";
            lbDireccionEntrega.Text = "";
            dataGridView2.Height = 0;
            dataGridView1.Height = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = database.ObtenerDatosEmpleados();
            dataGridView3.Columns["EmpleadoID"].Visible = false;
            dataGridView3.Columns["Telefono"].Visible = false;
            dataGridView3.Columns["Direccion"].Visible = false;
            dataGridView3.Columns["Nombre"].Width = 240;
            dataGridView3.Height = 90;
            if (textBox1.Text.Length >= 2)
            {
                var dt = database.BuscarEmpleado(textBox1.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView3.DataSource = dt;

                    dataGridView3.Columns["Nombre"].Width = 240;
                    dataGridView3.Columns["EmpleadoID"].Visible = false;
                    dataGridView3.Height = dataGridView3.Rows.Count * 50;
                }
                else
                {
                    dataGridView1.Height = 0;
                }

            }
            else if (textBox1.TextLength <= 0)
            {
                dataGridView3.DataSource = database.ObtenerDatosEmpleados();
                dataGridView3.Columns["EmpleadoID"].Visible = false;
                dataGridView3.Columns["Telefono"].Visible = false;
                dataGridView3.Columns["Direccion"].Visible = false;
                dataGridView3.Columns["Nombre"].Width = 240;
                dataGridView3.Height = 90;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            dataGridView3.DataSource = database.ObtenerDatosEmpleados();
            dataGridView3.Columns["EmpleadoID"].Visible = false;
            dataGridView3.Columns["Telefono"].Visible = false;
            dataGridView3.Columns["Direccion"].Visible = false;
            dataGridView3.Columns["Nombre"].Width = 240;
            dataGridView3.Height = 90;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView3.Rows[e.RowIndex];
            empleadoId = int.Parse(filaSeleccionada.Cells["EmpleadoID"].Value.ToString());
            textBox1.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dataGridView3.Height = 0;
        }
    }
}
