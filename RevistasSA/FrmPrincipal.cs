using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RevistasSA.Datos;

namespace RevistasSA
{
    public partial class FrmPrincipal : Form
    {
        private Database database;
        public FrmPrincipal(Database database)
        {
            InitializeComponent();
            this.database = database;
            FrmInicio frm = new FrmInicio();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);
            frm.Show();
        }
        private void AbrirForms(object frm)
        {
            //if (this.panelContenedor.Controls.Count > 0)
            //    this.panelContenedor.Controls.RemoveAt(0);
            //Form form = new Form();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(form);
            //this.panelContenedor.Tag = form;
            //form.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes(this, database);

            frmCliente.TopLevel = false;
            frmCliente.FormBorderStyle = FormBorderStyle.None;
            frmCliente.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frmCliente);
            frmCliente.Show();
        }

        private void btnRevistas_Click(object sender, EventArgs e)
        {
            FrmRevistas frmRevistas = new FrmRevistas(this, database);

            frmRevistas.TopLevel = false;
            frmRevistas.FormBorderStyle = FormBorderStyle.None;
            frmRevistas.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frmRevistas);
            frmRevistas.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados(this, database);

            frmEmpleados.TopLevel = false;
            frmEmpleados.FormBorderStyle = FormBorderStyle.None;
            frmEmpleados.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frmEmpleados);
            frmEmpleados.Show();
        }

        private void btnSuscripciones_Click(object sender, EventArgs e)
        {
            FrmSuscripciones frmSuscipciones = new FrmSuscripciones(this, database);

            frmSuscipciones.TopLevel = false;
            frmSuscipciones.FormBorderStyle = FormBorderStyle.None;
            frmSuscipciones.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frmSuscipciones);
            frmSuscipciones.Show();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            FrmEntregas frmEntregas = new FrmEntregas(this, database);

            frmEntregas.TopLevel = false;
            frmEntregas.FormBorderStyle = FormBorderStyle.None;
            frmEntregas.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frmEntregas);
            frmEntregas.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);
            frm.Show();
        }
    }
}
