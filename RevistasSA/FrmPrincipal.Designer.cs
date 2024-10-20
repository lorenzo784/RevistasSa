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
            panelContenedor = new Panel();
            label1 = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogo).BeginInit();
            BarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(0, 122, 204);
            Menu.Controls.Add(btnEntregas);
            Menu.Controls.Add(btnClientes);
            Menu.Controls.Add(btnSuscripciones);
            Menu.Controls.Add(btnEmpleados);
            Menu.Controls.Add(btnRevistas);
            Menu.Controls.Add(btnLogo);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(250, 720);
            Menu.TabIndex = 0;
            // 
            // btnEntregas
            // 
            btnEntregas.BackColor = Color.FromArgb(0, 122, 204);
            btnEntregas.FlatAppearance.BorderSize = 0;
            btnEntregas.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.Font = new Font("Times New Roman", 15.75F);
            btnEntregas.Location = new Point(0, 393);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Size = new Size(250, 62);
            btnEntregas.TabIndex = 5;
            btnEntregas.Text = "Entregas";
            btnEntregas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(0, 122, 204);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Times New Roman", 15.75F);
            btnClientes.ForeColor = SystemColors.ControlText;
            btnClientes.Location = new Point(0, 139);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(250, 62);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnSuscripciones
            // 
            btnSuscripciones.BackColor = Color.FromArgb(0, 122, 204);
            btnSuscripciones.FlatAppearance.BorderSize = 0;
            btnSuscripciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnSuscripciones.FlatStyle = FlatStyle.Flat;
            btnSuscripciones.Font = new Font("Times New Roman", 15.75F);
            btnSuscripciones.Location = new Point(0, 325);
            btnSuscripciones.Name = "btnSuscripciones";
            btnSuscripciones.Size = new Size(250, 62);
            btnSuscripciones.TabIndex = 4;
            btnSuscripciones.Text = "Suscripciones";
            btnSuscripciones.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(0, 122, 204);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Times New Roman", 15.75F);
            btnEmpleados.Location = new Point(0, 266);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(250, 62);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnRevistas
            // 
            btnRevistas.BackColor = Color.FromArgb(0, 122, 204);
            btnRevistas.FlatAppearance.BorderSize = 0;
            btnRevistas.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnRevistas.FlatStyle = FlatStyle.Flat;
            btnRevistas.Font = new Font("Times New Roman", 15.75F);
            btnRevistas.Location = new Point(0, 198);
            btnRevistas.Name = "btnRevistas";
            btnRevistas.Size = new Size(250, 62);
            btnRevistas.TabIndex = 2;
            btnRevistas.Text = "Revistas";
            btnRevistas.UseVisualStyleBackColor = false;
            // 
            // btnLogo
            // 
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(0, 0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(250, 133);
            btnLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogo.TabIndex = 0;
            btnLogo.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.Controls.Add(label1);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(800, 41);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(250, 43);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 677);
            panelContenedor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 36);
            label1.TabIndex = 0;
            label1.Text = "Revistas S.A.";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 720);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPincipal";
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
        private Panel panelContenedor;
        private Label label1;
    }
}