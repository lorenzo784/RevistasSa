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
            dataGridView3 = new DataGridView();
            textBox1 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 0;
            label1.Text = "Suscripción No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 1;
            label2.Text = "Fecha: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label3.Location = new Point(31, 177);
            label3.Name = "label3";
            label3.Size = new Size(206, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre del cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label4.Location = new Point(393, 177);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label5.Location = new Point(393, 243);
            label5.Name = "label5";
            label5.Size = new Size(46, 22);
            label5.TabIndex = 4;
            label5.Text = "Nit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label6.Location = new Point(393, 312);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label7.Location = new Point(31, 349);
            label7.Name = "label7";
            label7.Size = new Size(164, 22);
            label7.TabIndex = 6;
            label7.Text = "Para entrega en";
            // 
            // lbDireccionEntrega
            // 
            lbDireccionEntrega.AutoSize = true;
            lbDireccionEntrega.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbDireccionEntrega.Location = new Point(84, 388);
            lbDireccionEntrega.Name = "lbDireccionEntrega";
            lbDireccionEntrega.Size = new Size(112, 22);
            lbDireccionEntrega.TabIndex = 7;
            lbDireccionEntrega.Text = "Direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label9.Location = new Point(31, 429);
            label9.Name = "label9";
            label9.Size = new Size(239, 22);
            label9.TabIndex = 8;
            label9.Text = "Validez de suscripción";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label10.Location = new Point(73, 461);
            label10.Name = "label10";
            label10.Size = new Size(166, 22);
            label10.TabIndex = 9;
            label10.Text = "Fecha de inicio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label11.Location = new Point(73, 497);
            label11.Name = "label11";
            label11.Size = new Size(228, 22);
            label11.TabIndex = 10;
            label11.Text = "Fecha de finalización:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label12.Location = new Point(31, 542);
            label12.Name = "label12";
            label12.Size = new Size(90, 22);
            label12.TabIndex = 11;
            label12.Text = "Revista:";
            label12.Enter += tbBuscarRevista_Enter;
            // 
            // lbNoSuscripcion
            // 
            lbNoSuscripcion.AutoSize = true;
            lbNoSuscripcion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbNoSuscripcion.Location = new Point(204, 22);
            lbNoSuscripcion.Name = "lbNoSuscripcion";
            lbNoSuscripcion.Size = new Size(23, 22);
            lbNoSuscripcion.TabIndex = 12;
            lbNoSuscripcion.Text = "1";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbFecha.Location = new Point(128, 100);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(134, 22);
            lbFecha.TabIndex = 13;
            lbFecha.Text = "17/10/2024";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(245, 457);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.RightToLeft = RightToLeft.No;
            dtFechaInicio.Size = new Size(162, 30);
            dtFechaInicio.TabIndex = 14;
            // 
            // dtFechaFinalizacion
            // 
            dtFechaFinalizacion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            dtFechaFinalizacion.Format = DateTimePickerFormat.Short;
            dtFechaFinalizacion.Location = new Point(307, 493);
            dtFechaFinalizacion.Name = "dtFechaFinalizacion";
            dtFechaFinalizacion.Size = new Size(162, 30);
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
            dataGridView1.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.GridColor = Color.FromArgb(0, 122, 204);
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
            lbDireccion.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbDireccion.Location = new Point(404, 208);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(106, 22);
            lbDireccion.TabIndex = 18;
            lbDireccion.Text = "Direccion";
            // 
            // lbNit
            // 
            lbNit.AutoSize = true;
            lbNit.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbNit.Location = new Point(404, 274);
            lbNit.Name = "lbNit";
            lbNit.Size = new Size(40, 22);
            lbNit.TabIndex = 19;
            lbNit.Text = "Nit";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            lbTelefono.Location = new Point(404, 344);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(98, 22);
            lbTelefono.TabIndex = 20;
            lbTelefono.Text = "Telefono";
            // 
            // tbDireccionEntrega
            // 
            tbDireccionEntrega.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            tbDireccionEntrega.Location = new Point(196, 385);
            tbDireccionEntrega.Name = "tbDireccionEntrega";
            tbDireccionEntrega.Size = new Size(293, 30);
            tbDireccionEntrega.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.GridColor = Color.FromArgb(0, 122, 204);
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
            tbBuscarRevista.Location = new Point(127, 543);
            tbBuscarRevista.Name = "tbBuscarRevista";
            tbBuscarRevista.Size = new Size(264, 26);
            tbBuscarRevista.TabIndex = 24;
            tbBuscarRevista.TextChanged += tbBuscarRevista_TextChanged;
            tbBuscarRevista.Enter += tbBuscarRevista_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnAgregar.Location = new Point(648, 609);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 35);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.GridColor = Color.FromArgb(0, 122, 204);
            dataGridView3.Location = new Point(486, 58);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 30;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(264, 104);
            dataGridView3.TabIndex = 28;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 26);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label8.Location = new Point(349, 22);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 29;
            label8.Text = "Empleado: ";
            // 
            // FrmAgregarEntrega
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 677);
            Controls.Add(label8);
            Controls.Add(dataGridView3);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private Label label8;
    }
}