namespace RevistasSA
{
    partial class FrmEditarCliente
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
            btnAgregar = new Button();
            tbNit = new TextBox();
            label6 = new Label();
            tbTelefono = new TextBox();
            label5 = new Label();
            tbDireccion = new TextBox();
            label3 = new Label();
            tbApellido = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.guardar;
            btnAgregar.Location = new Point(557, 607);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 35);
            btnAgregar.TabIndex = 40;
            btnAgregar.Text = "Guardar cambios";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbNit
            // 
            tbNit.BackColor = Color.AliceBlue;
            tbNit.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNit.Location = new Point(54, 570);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(229, 30);
            tbNit.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label6.Location = new Point(54, 520);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 38;
            label6.Text = "NIT:";
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.AliceBlue;
            tbTelefono.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbTelefono.Location = new Point(54, 458);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(229, 30);
            tbTelefono.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label5.Location = new Point(54, 408);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 36;
            label5.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = Color.AliceBlue;
            tbDireccion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbDireccion.Location = new Point(54, 346);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(456, 30);
            tbDireccion.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label3.Location = new Point(54, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 34;
            label3.Text = "Direccion:";
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.AliceBlue;
            tbApellido.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbApellido.Location = new Point(54, 239);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(229, 30);
            tbApellido.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label4.Location = new Point(54, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 32;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label2.Location = new Point(54, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 31;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNombre.Location = new Point(54, 124);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 30);
            tbNombre.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(345, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 29;
            label1.Text = "Editar Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(624, 553);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(800, 677);
            Controls.Add(btnCancelar);
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
            Font = new Font("Lucida Fax", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEditarCliente";
            Text = "FrmEditarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox tbNit;
        private Label label6;
        private TextBox tbTelefono;
        private Label label5;
        private TextBox tbDireccion;
        private Label label3;
        private TextBox tbApellido;
        private Label label4;
        private Label label2;
        private TextBox tbNombre;
        private Label label1;
        private Button btnCancelar;
    }
}