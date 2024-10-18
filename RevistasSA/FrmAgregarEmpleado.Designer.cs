namespace RevistasSA
{
    partial class FrmAgregarEmpleado
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
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.AliceBlue;
            tbTelefono.Location = new Point(57, 525);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(229, 26);
            tbTelefono.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 471);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 16;
            label5.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = Color.AliceBlue;
            tbDireccion.Location = new Point(57, 407);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(456, 26);
            tbDireccion.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 353);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 14;
            label3.Text = "Direccion:";
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.AliceBlue;
            tbApellido.Location = new Point(57, 287);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(229, 26);
            tbApellido.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 12;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 11;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Location = new Point(57, 157);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 26);
            tbNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 19);
            label1.TabIndex = 9;
            label1.Text = "Agregar Empleado";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(458, 597);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 27);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(576, 682);
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
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAgregarEmpleado";
            Text = "FrmAgregarEmpleado";
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
        private Button btnAgregar;
    }
}