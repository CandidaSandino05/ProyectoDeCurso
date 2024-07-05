namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new Panel();
            label1 = new Label();
            btnRegistro = new Button();
            pictureBox1 = new PictureBox();
            BtnCalculodelir = new Button();
            btnNomina = new Button();
            btnNominasal = new Button();
            label2 = new Label();
            panelnom = new Panel();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelnom.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1467, 47);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegistro.Location = new Point(0, 228);
            btnRegistro.Margin = new Padding(3, 4, 3, 4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(251, 57);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.Image = Properties.Resources.ss;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnCalculodelir
            // 
            BtnCalculodelir.BackColor = Color.FromArgb(255, 255, 192);
            BtnCalculodelir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BtnCalculodelir.Location = new Point(0, 65);
            BtnCalculodelir.Margin = new Padding(3, 4, 3, 4);
            BtnCalculodelir.Name = "BtnCalculodelir";
            BtnCalculodelir.Size = new Size(248, 57);
            BtnCalculodelir.TabIndex = 2;
            BtnCalculodelir.Text = "Cálculo del IR";
            BtnCalculodelir.UseVisualStyleBackColor = false;
            BtnCalculodelir.Click += BtnCalculodelir_Click;
            // 
            // btnNomina
            // 
            btnNomina.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNomina.Location = new Point(0, 293);
            btnNomina.Margin = new Padding(3, 4, 3, 4);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(251, 57);
            btnNomina.TabIndex = 4;
            btnNomina.Text = "Nomina";
            btnNomina.UseVisualStyleBackColor = true;
            btnNomina.Click += btnNomina_Click;
            // 
            // btnNominasal
            // 
            btnNominasal.BackColor = Color.FromArgb(255, 255, 192);
            btnNominasal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNominasal.Location = new Point(-3, 0);
            btnNominasal.Margin = new Padding(3, 4, 3, 4);
            btnNominasal.Name = "btnNominasal";
            btnNominasal.Size = new Size(248, 57);
            btnNominasal.TabIndex = 1;
            btnNominasal.Text = "Nomina Salarial";
            btnNominasal.UseVisualStyleBackColor = false;
            btnNominasal.Click += btnNominasal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(72, 197);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Programa";
            // 
            // panelnom
            // 
            panelnom.Controls.Add(btnNominasal);
            panelnom.Controls.Add(BtnCalculodelir);
            panelnom.Location = new Point(3, 380);
            panelnom.Margin = new Padding(3, 4, 3, 4);
            panelnom.Name = "panelnom";
            panelnom.Size = new Size(248, 133);
            panelnom.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panelnom);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(btnNomina);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 47);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 768);
            panel1.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.WhiteSmoke;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 293);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.WhiteSmoke;
            pictureBox5.Image = Properties.Resources.regi;
            pictureBox5.Location = new Point(0, 231);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnRegistro;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1467, 815);
            Controls.Add(panel1);
            Controls.Add(panel3);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelnom.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Button btnRegistro;
        private PictureBox pictureBox1;
        private Button btnNomina;
        private Button BtnCalculodelir;
        private Button btnNominasal;
        private Label label2;
        private Panel panelnom;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}