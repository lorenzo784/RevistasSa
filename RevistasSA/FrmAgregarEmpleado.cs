﻿using RevistasSA.Datos;
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
        private FrmPrincipal inicio;
        public FrmAgregarEmpleado(Database database, FrmPrincipal inicio)
        {
            InitializeComponent();
            this.database = database;
            this.inicio = inicio;
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
            database.InsertarEmpleado(nombre, apellido, telefono, direccion);
            MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
            mostrarDatos();
        }

        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
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
