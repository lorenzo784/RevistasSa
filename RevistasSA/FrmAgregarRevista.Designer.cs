namespace RevistasSA
{
    partial class FrmAgregarRevista
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
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // tbFrecuencia
            // 
            tbFrecuencia.BackColor = Color.AliceBlue;
            tbFrecuencia.Location = new Point(60, 479);
            tbFrecuencia.Name = "tbFrecuencia";
            tbFrecuencia.Size = new Size(229, 26);
            tbFrecuencia.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 429);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 35;
            label5.Text = "Frecuencia:";
            // 
            // tbCategoria
            // 
            tbCategoria.BackColor = Color.AliceBlue;
            tbCategoria.Location = new Point(60, 367);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(229, 26);
            tbCategoria.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 321);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 33;
            label3.Text = "Categoria:";
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.AliceBlue;
            tbPrecio.Location = new Point(60, 260);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(229, 26);
            tbPrecio.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 207);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 31;
            label4.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 30;
            label2.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.AliceBlue;
            tbNombre.Location = new Point(60, 145);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(229, 26);
            tbNombre.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 28;
            label1.Text = "Agregar Revista";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(431, 587);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 34);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarRevista
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(576, 682);
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
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAgregarRevista";
            Text = "FrmAgregarRevista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNit;
        private TextBox tbTelefono;
        private TextBox tbFrecuencia;
        private Label label5;
        private TextBox tbCategoria;
        private TextBox tbCorreo;
        private Label label3;
        private TextBox tbPrecio;
        private Label label4;
        private Label label2;
        private TextBox tbNombre;
        private Label label1;
        private Button btnAgregar;
    }
}