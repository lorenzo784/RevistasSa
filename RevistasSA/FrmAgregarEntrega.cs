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

                string consulta = "SELECT ClienteID, CONCAT(Nombre, ' ', Apellido) as Nombre, Nit, Direccion, Telefono " +
                                "FROM Cliente WHERE Nombre LIKE @Cliente OR Nit LIKE @Cliente";
                try
                {
                    SqlCommand cmd = new SqlCommand(consulta, database.cn);

                    cmd.Parameters.AddWithValue("@Cliente", $"%{tbBuscarCliente.Text}%"); // Reemplaza 'nombre' por el valor que desees buscar

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.ToString());
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
            long segundos = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            int numeroUnico = (int)(segundos % 100000000);
            string numeroUnicoString = numeroUnico.ToString("D8");
            var fechaInicio = dtFechaInicio.Value;
            var fechaFin = dtFechaFinalizacion.Value;
            var fechaActual = DateTime.Now;
            database.InsertarSuscripcion(clienteId, revistaId, fechaInicio, fechaFin, numeroUnicoString);
            int suscripcionId = database.ObtenerUltimaSuscripcion();
            database.InsertarEntrega(suscripcionId, 1, fechaActual, fechaActual, tbDireccionEntrega.Text, lbTelefono.Text, "");
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

    }
}
