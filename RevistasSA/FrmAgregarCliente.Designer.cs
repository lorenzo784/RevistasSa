namespace RevistasSA
{
    partial class FrmAgregarCliente
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
            label1 = new Label();
            tbTelefono = new TextBox();
            label5 = new Label();
            tbDireccion = new TextBox();
            label3 = new Label();
            tbApellido = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            tbNit = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(355, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cliente";
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.AliceBlue;
            tbTelefono.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbTelefono.Location = new Point(64, 454);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(229, 30);
            tbTelefono.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label5.Location = new Point(64, 404);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 24;
            label5.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = Color.AliceBlue;
            tbDireccion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbDireccion.Location = new Point(64, 342);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(456, 30);
            tbDireccion.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label3.Location = new Point(64, 296);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 22;
            label3.Text = "Direccion:";
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.AliceBlue;
            tbApellido.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbApellido.Location = new Point(64, 235);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(229, 30);
            tbApellido.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label4.Location = new Point(64, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 20;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label2.Location = new Point(64, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 19;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNombre.Location = new Point(64, 120);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 30);
            tbNombre.TabIndex = 18;
            // 
            // tbNit
            // 
            tbNit.BackColor = Color.AliceBlue;
            tbNit.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNit.Location = new Point(64, 566);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(229, 30);
            tbNit.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label6.Location = new Point(64, 516);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 26;
            label6.Text = "NIT:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnAgregar.Location = new Point(645, 603);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 35);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 677);
            Controls.Add(btnAgregar);
            Controls.Add(tbNit);
            Controls.Add(label6);
            Controls.Add(tbTelefono);
            Controls.Add(label5);
            Controls.Add(tbDireccion);
            Controls.Add(label3);
            Controls.Add(tbApellido);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAgregarCliente";
            Text = "FrmAgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTelefono;
        private Label label5;
        private TextBox tbDireccion;
        private Label label3;
        private TextBox tbApellido;
        private Label label4;
        private Label label2;
        private TextBox tbNombre;
        private TextBox tbNit;
        private Label label6;
        private Button btnAgregar;
    }
}