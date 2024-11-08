namespace RevistasSA
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            Menu = new Panel();
            btnEntregas = new Button();
            btnClientes = new Button();
            btnSuscripciones = new Button();
            btnEmpleados = new Button();
            btnRevistas = new Button();
            btnLogo = new PictureBox();
            BarraTitulo = new Panel();
            label1 = new Label();
            panelContenedor = new Panel();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogo).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(0, 122, 204);
            Menu.BackgroundImage = Properties.Resources.fondo;
            Menu.Controls.Add(btnEntregas);
            Menu.Controls.Add(btnClientes);
            Menu.Controls.Add(btnSuscripciones);
            Menu.Controls.Add(btnEmpleados);
            Menu.Controls.Add(btnRevistas);
            Menu.Controls.Add(btnLogo);
            Menu.Dock = DockStyle.Left;
            Menu.Font = new Font("Segoe UI Emoji", 9F);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(250, 720);
            Menu.TabIndex = 0;
            // 
            // btnEntregas
            // 
            btnEntregas.BackColor = Color.Transparent;
            btnEntregas.FlatAppearance.BorderSize = 0;
            btnEntregas.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnEntregas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnEntregas.Image = Properties.Resources.entrega_rapida;
            btnEntregas.Location = new Point(0, 393);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Size = new Size(250, 62);
            btnEntregas.TabIndex = 5;
            btnEntregas.Text = "Entregas";
            btnEntregas.TextAlign = ContentAlignment.MiddleRight;
            btnEntregas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntregas.UseVisualStyleBackColor = false;
            btnEntregas.Click += btnEntregas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnClientes.ForeColor = SystemColors.ControlText;
            btnClientes.Image = Properties.Resources.clientes24;
            btnClientes.Location = new Point(0, 139);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(250, 62);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnSuscripciones
            // 
            btnSuscripciones.BackColor = Color.Transparent;
            btnSuscripciones.FlatAppearance.BorderSize = 0;
            btnSuscripciones.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnSuscripciones.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnSuscripciones.FlatStyle = FlatStyle.Flat;
            btnSuscripciones.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnSuscripciones.Image = Properties.Resources.suscripcion;
            btnSuscripciones.Location = new Point(0, 325);
            btnSuscripciones.Name = "btnSuscripciones";
            btnSuscripciones.Size = new Size(250, 62);
            btnSuscripciones.TabIndex = 4;
            btnSuscripciones.Text = "Suscripciones";
            btnSuscripciones.TextAlign = ContentAlignment.MiddleRight;
            btnSuscripciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuscripciones.UseVisualStyleBackColor = false;
            btnSuscripciones.Click += btnSuscripciones_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnEmpleados.Image = Properties.Resources.empleado;
            btnEmpleados.Location = new Point(0, 266);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(250, 62);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnRevistas
            // 
            btnRevistas.BackColor = Color.Transparent;
            btnRevistas.FlatAppearance.BorderSize = 0;
            btnRevistas.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnRevistas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnRevistas.FlatStyle = FlatStyle.Flat;
            btnRevistas.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnRevistas.Image = Properties.Resources.revista;
            btnRevistas.Location = new Point(0, 198);
            btnRevistas.Name = "btnRevistas";
            btnRevistas.Size = new Size(250, 62);
            btnRevistas.TabIndex = 2;
            btnRevistas.Text = "Revistas";
            btnRevistas.TextAlign = ContentAlignment.MiddleRight;
            btnRevistas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRevistas.UseVisualStyleBackColor = false;
            btnRevistas.Click += btnRevistas_Click;
            // 
            // btnLogo
            // 
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(53, 29);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(140, 104);
            btnLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogo.TabIndex = 0;
            btnLogo.TabStop = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 122, 204);
            BarraTitulo.BackgroundImage = Properties.Resources.fondo;
            BarraTitulo.Controls.Add(label1);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Font = new Font("Segoe UI Emoji", 9F);
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(800, 41);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 0;
            label1.Text = "Revistas S.A.";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(0, 122, 204);
            panelContenedor.BackgroundImage = Properties.Resources.fondo;
            panelContenedor.Font = new Font("Segoe UI Emoji", 9F);
            panelContenedor.Location = new Point(250, 43);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 677);
            panelContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 720);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(Menu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revistas SA";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogo).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu;
        private Button btnEntregas;
        private Button btnSuscripciones;
        private Button btnEmpleados;
        private Button btnRevistas;
        private Button btnClientes;
        private PictureBox btnLogo;
        private Panel BarraTitulo;
        public Panel panelContenedor;
        private Label label1;
    }
}