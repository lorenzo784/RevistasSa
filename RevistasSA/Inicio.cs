using RevistasSA.Datos;

namespace RevistasSA
{
    public partial class FrmInicio : Form
    {
        private Database database;
        public FrmInicio(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes(this, database);

            frmCliente.TopLevel = false;
            frmCliente.FormBorderStyle = FormBorderStyle.None;
            frmCliente.Dock = DockStyle.Fill;

            pContenedor.Controls.Clear();

            pContenedor.Controls.Add(frmCliente);
            frmCliente.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados(this, database);

            frmEmpleados.TopLevel = false;
            frmEmpleados.FormBorderStyle = FormBorderStyle.None;
            frmEmpleados.Dock = DockStyle.Fill;

            pContenedor.Controls.Clear();

            pContenedor.Controls.Add(frmEmpleados);
            frmEmpleados.Show();
        }

        private void btnRevistas_Click(object sender, EventArgs e)
        {
            FrmRevistas frmRevistas = new FrmRevistas(this, database);

            frmRevistas.TopLevel = false;
            frmRevistas.FormBorderStyle = FormBorderStyle.None;
            frmRevistas.Dock = DockStyle.Fill;

            pContenedor.Controls.Clear();

            pContenedor.Controls.Add(frmRevistas);
            frmRevistas.Show();
        }

        private void btnSuscripciones_Click(object sender, EventArgs e)
        {
            FrmSuscripciones frmSuscipciones = new FrmSuscripciones(this, database);

            frmSuscipciones.TopLevel = false;
            frmSuscipciones.FormBorderStyle = FormBorderStyle.None;
            frmSuscipciones.Dock = DockStyle.Fill;

            pContenedor.Controls.Clear();

            pContenedor.Controls.Add(frmSuscipciones);
            frmSuscipciones.Show();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            FrmEntregas frmEntregas = new FrmEntregas(this, database);

            frmEntregas.TopLevel = false;
            frmEntregas.FormBorderStyle = FormBorderStyle.None;
            frmEntregas.Dock = DockStyle.Fill;

            pContenedor.Controls.Clear();

            pContenedor.Controls.Add(frmEntregas);
            frmEntregas.Show();
        }
    }
}
