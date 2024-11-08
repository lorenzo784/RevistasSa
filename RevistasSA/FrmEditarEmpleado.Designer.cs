namespace RevistasSA
{
    partial class FrmEditarEmpleado
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
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.AliceBlue;
            tbTelefono.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbTelefono.Location = new Point(55, 520);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(229, 30);
            tbTelefono.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label5.Location = new Point(55, 466);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 26;
            label5.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = Color.AliceBlue;
            tbDireccion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbDireccion.Location = new Point(55, 402);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(456, 30);
            tbDireccion.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label3.Location = new Point(55, 348);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 24;
            label3.Text = "Direccion:";
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.AliceBlue;
            tbApellido.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbApellido.Location = new Point(55, 282);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(229, 30);
            tbApellido.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label4.Location = new Point(55, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 22;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label2.Location = new Point(55, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 21;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNombre.Location = new Point(55, 152);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 30);
            tbNombre.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(345, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 19;
            label1.Text = "Editar Empleado";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Lucida Fax", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(633, 540);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.guardar;
            btnAgregar.Location = new Point(566, 594);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 35);
            btnAgregar.TabIndex = 42;
            btnAgregar.Text = "Guardar cambios";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmEditarEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(800, 677);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(tbTelefono);
            Controls.Add(label5);
            Controls.Add(tbDireccion);
            Controls.Add(label3);
            Controls.Add(tbApellido);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEditarEmpleado";
            Text = "FrmEditarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnAgregar;
    }
}