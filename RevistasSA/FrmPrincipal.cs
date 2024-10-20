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
      
        public FrmPrincipal()
        {
            InitializeComponent();
         
        }
        private void AbrirForms(object frm)
        { 
            if(this.panelContenedor.Controls.Count>0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form form = new Form();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill; 
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
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
            
        }

    }
}
