namespace RevistasSA
{
    partial class FrmAgregarEntrega
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbDireccionEntrega = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lbNoSuscripcion = new Label();
            lbFecha = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinalizacion = new DateTimePicker();
            tbBuscarCliente = new TextBox();
            dataGridView1 = new DataGridView();
            lbDireccion = new Label();
            lbNit = new Label();
            lbTelefono = new Label();
            tbDireccionEntrega = new TextBox();
            dataGridView2 = new DataGridView();
            tbBuscarRevista = new TextBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 0;
            label1.Text = "Suscripción No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 1;
            label2.Text = "Fecha: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 177);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre del cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 136);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(383, 202);
            label5.Name = "label5";
            label5.Size = new Size(40, 22);
            label5.TabIndex = 4;
            label5.Text = "Nit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(383, 271);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 349);
            label7.Name = "label7";
            label7.Size = new Size(141, 22);
            label7.TabIndex = 6;
            label7.Text = "Para entrega en";
            // 
            // lbDireccionEntrega
            // 
            lbDireccionEntrega.AutoSize = true;
            lbDireccionEntrega.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDireccionEntrega.Location = new Point(84, 388);
            lbDireccionEntrega.Name = "lbDireccionEntrega";
            lbDireccionEntrega.Size = new Size(89, 22);
            lbDireccionEntrega.TabIndex = 7;
            lbDireccionEntrega.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 429);
            label9.Name = "label9";
            label9.Size = new Size(189, 22);
            label9.TabIndex = 8;
            label9.Text = "Validez de suscripción";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(73, 461);
            label10.Name = "label10";
            label10.Size = new Size(138, 22);
            label10.TabIndex = 9;
            label10.Text = "Fecha de inicio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(73, 497);
            label11.Name = "label11";
            label11.Size = new Size(182, 22);
            label11.TabIndex = 10;
            label11.Text = "Fecha de finalización";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(31, 542);
            label12.Name = "label12";
            label12.Size = new Size(76, 22);
            label12.TabIndex = 11;
            label12.Text = "Revista:";
            label12.Enter += tbBuscarRevista_Enter;
            // 
            // lbNoSuscripcion
            // 
            lbNoSuscripcion.AutoSize = true;
            lbNoSuscripcion.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNoSuscripcion.Location = new Point(176, 22);
            lbNoSuscripcion.Name = "lbNoSuscripcion";
            lbNoSuscripcion.Size = new Size(20, 22);
            lbNoSuscripcion.TabIndex = 12;
            lbNoSuscripcion.Text = "1";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(128, 100);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(100, 22);
            lbFecha.TabIndex = 13;
            lbFecha.Text = "17/10/2024";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(227, 457);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.RightToLeft = RightToLeft.No;
            dtFechaInicio.Size = new Size(121, 26);
            dtFechaInicio.TabIndex = 14;
            // 
            // dtFechaFinalizacion
            // 
            dtFechaFinalizacion.Format = DateTimePickerFormat.Short;
            dtFechaFinalizacion.Location = new Point(270, 493);
            dtFechaFinalizacion.Name = "dtFechaFinalizacion";
            dtFechaFinalizacion.Size = new Size(118, 26);
            dtFechaFinalizacion.TabIndex = 15;
            // 
            // tbBuscarCliente
            // 
            tbBuscarCliente.Location = new Point(84, 202);
            tbBuscarCliente.Name = "tbBuscarCliente";
            tbBuscarCliente.Size = new Size(264, 26);
            tbBuscarCliente.TabIndex = 16;
            tbBuscarCliente.TextChanged += tbBuscarCliente_TextChanged;
            tbBuscarCliente.Enter += tbBuscarCliente_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.BlanchedAlmond;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.GridColor = Color.BlanchedAlmond;
            dataGridView1.Location = new Point(84, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(264, 104);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDireccion.Location = new Point(394, 167);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(89, 22);
            lbDireccion.TabIndex = 18;
            lbDireccion.Text = "Direccion";
            // 
            // lbNit
            // 
            lbNit.AutoSize = true;
            lbNit.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNit.Location = new Point(394, 233);
            lbNit.Name = "lbNit";
            lbNit.Size = new Size(35, 22);
            lbNit.TabIndex = 19;
            lbNit.Text = "Nit";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelefono.Location = new Point(394, 303);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(80, 22);
            lbTelefono.TabIndex = 20;
            lbTelefono.Text = "Telefono";
            // 
            // tbDireccionEntrega
            // 
            tbDireccionEntrega.Location = new Point(190, 388);
            tbDireccionEntrega.Name = "tbDireccionEntrega";
            tbDireccionEntrega.Size = new Size(293, 26);
            tbDireccionEntrega.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.BlanchedAlmond;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.GridColor = Color.BlanchedAlmond;
            dataGridView2.Location = new Point(113, 575);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(264, 104);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.Enter += tbBuscarRevista_Enter;
            // 
            // tbBuscarRevista
            // 
            tbBuscarRevista.Location = new Point(113, 538);
            tbBuscarRevista.Name = "tbBuscarRevista";
            tbBuscarRevista.Size = new Size(264, 26);
            tbBuscarRevista.TabIndex = 24;
            tbBuscarRevista.TextChanged += tbBuscarRevista_TextChanged;
            tbBuscarRevista.Enter += tbBuscarRevista_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(456, 608);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 27);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregarEntrega
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(576, 682);
            Controls.Add(btnAgregar);
            Controls.Add(tbBuscarRevista);
            Controls.Add(dataGridView2);
            Controls.Add(tbDireccionEntrega);
            Controls.Add(lbTelefono);
            Controls.Add(lbNit);
            Controls.Add(lbDireccion);
            Controls.Add(dataGridView1);
            Controls.Add(tbBuscarCliente);
            Controls.Add(dtFechaFinalizacion);
            Controls.Add(dtFechaInicio);
            Controls.Add(lbFecha);
            Controls.Add(lbNoSuscripcion);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lbDireccionEntrega);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAgregarEntrega";
            Text = "FrmAgregarEntrega";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbDireccionEntrega;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lbNoSuscripcion;
        private Label lbFecha;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFinalizacion;
        private TextBox tbBuscarCliente;
        private DataGridView dataGridView1;
        private Label lbDireccion;
        private Label lbNit;
        private Label lbTelefono;
        private TextBox tbDireccionEntrega;
        private DataGridView dataGridView2;
        private TextBox tbBuscarRevista;
        private Button btnAgregar;
    }
}