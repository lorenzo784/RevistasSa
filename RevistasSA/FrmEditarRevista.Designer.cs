﻿namespace RevistasSA
{
    partial class FrmEditarRevista
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
            tbFrecuencia = new TextBox();
            label5 = new Label();
            tbCategoria = new TextBox();
            label3 = new Label();
            tbPrecio = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // tbFrecuencia
            // 
            tbFrecuencia.BackColor = Color.AliceBlue;
            tbFrecuencia.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbFrecuencia.Location = new Point(292, 518);
            tbFrecuencia.Name = "tbFrecuencia";
            tbFrecuencia.Size = new Size(229, 30);
            tbFrecuencia.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label5.Location = new Point(292, 468);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 45;
            label5.Text = "Frecuencia:";
            // 
            // tbCategoria
            // 
            tbCategoria.BackColor = Color.AliceBlue;
            tbCategoria.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbCategoria.Location = new Point(292, 406);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(229, 30);
            tbCategoria.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label3.Location = new Point(292, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 43;
            label3.Text = "Categoria:";
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.AliceBlue;
            tbPrecio.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbPrecio.Location = new Point(292, 299);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(229, 30);
            tbPrecio.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label4.Location = new Point(292, 246);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 41;
            label4.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label2.Location = new Point(292, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 40;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbNombre.Location = new Point(292, 184);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 30);
            tbNombre.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(292, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 38;
            label1.Text = "Editar Revista";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Lucida Fax", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(643, 547);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 48;
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
            btnAgregar.Location = new Point(576, 601);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 35);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "Guardar cambios";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmEditarRevista
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 677);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(tbFrecuencia);
            Controls.Add(label5);
            Controls.Add(tbCategoria);
            Controls.Add(label3);
            Controls.Add(tbPrecio);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEditarRevista";
            Text = "FrmEditarRevista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbFrecuencia;
        private Label label5;
        private TextBox tbCategoria;
        private Label label3;
        private TextBox tbPrecio;
        private Label label4;
        private Label label2;
        private TextBox tbNombre;
        private Label label1;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}