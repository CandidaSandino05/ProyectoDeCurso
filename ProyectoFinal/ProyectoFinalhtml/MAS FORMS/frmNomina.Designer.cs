namespace ProyectoFinal.MAS_FORMS
{
    partial class frmNomina
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
            panel1 = new Panel();
            label1 = new Label();
            btnImprimir = new Button();
            dgvCalculoNomina = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnImprimir);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 71);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(2, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 35);
            label1.TabIndex = 2;
            label1.Text = "Nómina Salarial Mensual";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnImprimir.Location = new Point(818, 16);
            btnImprimir.Margin = new Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(122, 51);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dgvCalculoNomina
            // 
            dgvCalculoNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalculoNomina.Location = new Point(0, 93);
            dgvCalculoNomina.Margin = new Padding(3, 4, 3, 4);
            dgvCalculoNomina.Name = "dgvCalculoNomina";
            dgvCalculoNomina.RowHeadersWidth = 51;
            dgvCalculoNomina.RowTemplate.Height = 25;
            dgvCalculoNomina.Size = new Size(974, 463);
            dgvCalculoNomina.TabIndex = 1;
            // 
            // frmNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(965, 600);
            Controls.Add(dgvCalculoNomina);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNomina";
            Load += frmNomina_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnImprimir;
        private Label label1;
        private DataGridView dgvCalculoNomina;
    }
}