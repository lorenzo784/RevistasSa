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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevistasSA
{
    public partial class FrmAgregarCliente : Form
    {
        Database database;
        public FrmAgregarCliente(Database database)
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
            string nit = tbNit.Text;
            database.InsertarCliente(nombre, apellido, direccion, telefono, nit);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            tbNit.Text = "";
        }
    }
}