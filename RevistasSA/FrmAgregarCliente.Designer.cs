﻿namespace RevistasSA
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
            label1.Location = new Point(226, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cliente";
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.AliceBlue;
            tbTelefono.Location = new Point(64, 454);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(229, 26);
            tbTelefono.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 404);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 24;
            label5.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = Color.AliceBlue;
            tbDireccion.Location = new Point(64, 342);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(456, 26);
            tbDireccion.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 296);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 22;
            label3.Text = "Direccion:";
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.AliceBlue;
            tbApellido.Location = new Point(64, 235);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(229, 26);
            tbApellido.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 20;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 19;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Location = new Point(64, 120);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 26);
            tbNombre.TabIndex = 18;
            // 
            // tbNit
            // 
            tbNit.BackColor = Color.AliceBlue;
            tbNit.Location = new Point(64, 566);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(229, 26);
            tbNit.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 516);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 19);
            label6.TabIndex = 26;
            label6.Text = "NIT:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(445, 617);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(87, 27);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(576, 682);
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