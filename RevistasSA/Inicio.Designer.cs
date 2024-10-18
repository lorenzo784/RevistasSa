namespace RevistasSA
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pContenedor = new Panel();
            label1 = new Label();
            btnClientes = new Button();
            pOpciones = new Panel();
            btnEntregas = new Button();
            btnSuscripciones = new Button();
            btnEmpleados = new Button();
            btnRevistas = new Button();
            pOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.Location = new Point(233, 3);
            pContenedor.Margin = new Padding(4);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(576, 682);
            pContenedor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 6);
            label1.Name = "label1";
            label1.Size = new Size(145, 24);
            label1.TabIndex = 0;
            label1.Text = "Revistas S.A.";
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.BackgroundImageLayout = ImageLayout.Center;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(12, 75);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(198, 32);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pOpciones
            // 
            pOpciones.Controls.Add(btnEntregas);
            pOpciones.Controls.Add(btnSuscripciones);
            pOpciones.Controls.Add(btnEmpleados);
            pOpciones.Controls.Add(btnRevistas);
            pOpciones.Controls.Add(label1);
            pOpciones.Controls.Add(btnClientes);
            pOpciones.Location = new Point(1, 3);
            pOpciones.Margin = new Padding(4);
            pOpciones.Name = "pOpciones";
            pOpciones.Size = new Size(224, 682);
            pOpciones.TabIndex = 0;
            // 
            // btnEntregas
            // 
            btnEntregas.BackColor = Color.Transparent;
            btnEntregas.BackgroundImageLayout = ImageLayout.Center;
            btnEntregas.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            btnEntregas.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.Location = new Point(12, 280);
            btnEntregas.Margin = new Padding(4);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Size = new Size(198, 32);
            btnEntregas.TabIndex = 5;
            btnEntregas.Text = "Entregas";
            btnEntregas.UseVisualStyleBackColor = false;
            btnEntregas.Click += btnEntregas_Click;
            // 
            // btnSuscripciones
            // 
            btnSuscripciones.BackColor = Color.Transparent;
            btnSuscripciones.BackgroundImageLayout = ImageLayout.Center;
            btnSuscripciones.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            btnSuscripciones.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnSuscripciones.FlatStyle = FlatStyle.Flat;
            btnSuscripciones.Location = new Point(12, 231);
            btnSuscripciones.Margin = new Padding(4);
            btnSuscripciones.Name = "btnSuscripciones";
            btnSuscripciones.Size = new Size(198, 32);
            btnSuscripciones.TabIndex = 4;
            btnSuscripciones.Text = "Suscripciones";
            btnSuscripciones.UseVisualStyleBackColor = false;
            btnSuscripciones.Click += btnSuscripciones_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.BackgroundImageLayout = ImageLayout.Center;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Location = new Point(12, 179);
            btnEmpleados.Margin = new Padding(4);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(198, 32);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnRevistas
            // 
            btnRevistas.BackColor = Color.Transparent;
            btnRevistas.BackgroundImageLayout = ImageLayout.Center;
            btnRevistas.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            btnRevistas.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnRevistas.FlatStyle = FlatStyle.Flat;
            btnRevistas.Location = new Point(12, 128);
            btnRevistas.Margin = new Padding(4);
            btnRevistas.Name = "btnRevistas";
            btnRevistas.Size = new Size(198, 32);
            btnRevistas.TabIndex = 2;
            btnRevistas.Text = "Revistas";
            btnRevistas.UseVisualStyleBackColor = false;
            btnRevistas.Click += btnRevistas_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(804, 681);
            Controls.Add(pOpciones);
            Controls.Add(pContenedor);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            pOpciones.ResumeLayout(false);
            pOpciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pContenedor;
        private Panel pOpciones;
        private Button btnClientes;
        private Label label1;
        private Button btnRevistas;
        private Button btnEmpleados;
        private Button btnEntregas;
        private Button btnSuscripciones;
    }
}
