namespace RevistasSA
{
    partial class FrmSuscripciones
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
            dgvSuscipciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSuscipciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 34);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = "Suscripciones";
            // 
            // dgvSuscipciones
            // 
            dgvSuscipciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuscipciones.Location = new Point(44, 109);
            dgvSuscipciones.Name = "dgvSuscipciones";
            dgvSuscipciones.Size = new Size(475, 509);
            dgvSuscipciones.TabIndex = 2;
            // 
            // FrmSuscripciones
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(576, 682);
            Controls.Add(dgvSuscipciones);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmSuscripciones";
            Text = "FrmSuscripciones";
            ((System.ComponentModel.ISupportInitialize)dgvSuscipciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSuscipciones;
    }
}