namespace RevistasSA
{
    partial class FrmEntregas
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
            btnAgregar = new Button();
            dgvEntregas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(354, 34);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 0;
            label1.Text = "Entregas";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.anadir16;
            btnAgregar.Location = new Point(634, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.BackgroundColor = SystemColors.ControlLightLight;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntregas.Location = new Point(45, 111);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.Size = new Size(702, 521);
            dgvEntregas.TabIndex = 2;
            dgvEntregas.CellContentClick += dgvEntregas_CellContentClick;
            // 
            // FrmEntregas
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(800, 677);
            Controls.Add(dgvEntregas);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEntregas";
            Text = "FrmEntregas";
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private DataGridView dgvEntregas;
    }
}