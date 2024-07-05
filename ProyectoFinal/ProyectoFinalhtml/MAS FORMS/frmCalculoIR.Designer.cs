namespace ProyectoFinal.MAS_FORMS
{
    partial class frmCalculoIR
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
            dgir = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 71);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(288, 12);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 1;
            label1.Text = "Cálculo del IR";
            label1.Click += label1_Click;
            // 
            // dgir
            // 
            dgir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgir.Location = new Point(14, 99);
            dgir.Margin = new Padding(3, 4, 3, 4);
            dgir.Name = "dgir";
            dgir.RowHeadersWidth = 51;
            dgir.RowTemplate.Height = 25;
            dgir.Size = new Size(770, 405);
            dgir.TabIndex = 1;
            dgir.CellContentClick += dgir_CellContentClick;
            // 
            // frmCalculoIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(808, 532);
            Controls.Add(dgir);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCalculoIR";
            Load += frmCalculoIR_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgir;
    }
}