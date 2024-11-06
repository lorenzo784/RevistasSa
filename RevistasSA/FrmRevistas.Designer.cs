namespace RevistasSA
{
    partial class FrmRevistas
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
            dgvRevistas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label1.Location = new Point(340, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 0;
            label1.Text = "Revistas";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            btnAgregar.Location = new Point(649, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvRevistas
            // 
            dgvRevistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevistas.Location = new Point(43, 111);
            dgvRevistas.Name = "dgvRevistas";
            dgvRevistas.Size = new Size(705, 506);
            dgvRevistas.TabIndex = 2;
            // 
            // FrmRevistas
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 677);
            Controls.Add(dgvRevistas);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmRevistas";
            Text = "FrmRevistas";
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private DataGridView dgvRevistas;
    }
}