namespace ProyectoFinal.MAS_FORMS
{
    partial class frmRegistrar
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
            dataGridView1 = new DataGridView();
            lblNoEmpleado = new Label();
            txtNoEmpleado = new TextBox();
            dtFechaNacimiento = new DateTimePicker();
            cmCargo = new ComboBox();
            lblUnidadesVendidas = new Label();
            lblCargo = new Label();
            lblApellidos = new Label();
            txtNombres = new Label();
            txtEmpleado = new TextBox();
            txtApellidos = new TextBox();
            lblTelefono = new Label();
            lblEstadoCivil = new Label();
            lblSexo = new Label();
            lblFechaNacimiento = new Label();
            dtFechaSalida = new DateTimePicker();
            dtFechaIngreso = new DateTimePicker();
            txtUnidadesaVendidas = new TextBox();
            txtTelefono = new TextBox();
            cmSexo = new ComboBox();
            cmEstadoCivil = new ComboBox();
            lblActividad = new Label();
            lblFechaSalida = new Label();
            lblFechaIngreso = new Label();
            cmActividad = new ComboBox();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            txtNumcedula = new TextBox();
            lblNumCedula = new Label();
            lblNumeroInss = new Label();
            lblNumruc = new Label();
            txtNumruc = new TextBox();
            txtNuminss = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 463);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 192);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNoEmpleado
            // 
            lblNoEmpleado.AutoSize = true;
            lblNoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNoEmpleado.Location = new Point(27, 24);
            lblNoEmpleado.Name = "lblNoEmpleado";
            lblNoEmpleado.Size = new Size(103, 20);
            lblNoEmpleado.TabIndex = 1;
            lblNoEmpleado.Text = "No Empleado";
            // 
            // txtNoEmpleado
            // 
            txtNoEmpleado.Location = new Point(141, 17);
            txtNoEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtNoEmpleado.Name = "txtNoEmpleado";
            txtNoEmpleado.Size = new Size(157, 27);
            txtNoEmpleado.TabIndex = 1;
            txtNoEmpleado.TextChanged += txtNoEmpleado_TextChanged;
            txtNoEmpleado.KeyPress += txtNoEmpleado_KeyPress;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(141, 325);
            dtFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(228, 27);
            dtFechaNacimiento.TabIndex = 8;
            // 
            // cmCargo
            // 
            cmCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmCargo.FormattingEnabled = true;
            cmCargo.Items.AddRange(new object[] { "Gerente General", "Contador", "Director de RR.HH", "Supervisor" });
            cmCargo.Location = new Point(141, 264);
            cmCargo.Margin = new Padding(3, 4, 3, 4);
            cmCargo.Name = "cmCargo";
            cmCargo.Size = new Size(157, 28);
            cmCargo.TabIndex = 7;
            // 
            // lblUnidadesVendidas
            // 
            lblUnidadesVendidas.AutoSize = true;
            lblUnidadesVendidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnidadesVendidas.Location = new Point(443, 243);
            lblUnidadesVendidas.Name = "lblUnidadesVendidas";
            lblUnidadesVendidas.Size = new Size(141, 20);
            lblUnidadesVendidas.TabIndex = 6;
            lblUnidadesVendidas.Text = "Unidades Vendidas";
            lblUnidadesVendidas.Click += lblUnidadesVendidas_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCargo.Location = new Point(32, 272);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(50, 20);
            lblCargo.TabIndex = 7;
            lblCargo.Text = "Cargo";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidos.Location = new Point(27, 228);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(74, 20);
            lblApellidos.TabIndex = 8;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.AutoSize = true;
            txtNombres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombres.Location = new Point(27, 184);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(74, 20);
            txtNombres.TabIndex = 9;
            txtNombres.Text = "Nombres";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(141, 177);
            txtEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(157, 27);
            txtEmpleado.TabIndex = 5;
            txtEmpleado.KeyPress += txtEmpleado_KeyPress;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(141, 221);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(157, 27);
            txtApellidos.TabIndex = 6;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(472, 55);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoCivil.Location = new Point(466, 17);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(87, 20);
            lblEstadoCivil.TabIndex = 13;
            lblEstadoCivil.Text = "Estado civil";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSexo.Location = new Point(32, 393);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(42, 20);
            lblSexo.TabIndex = 14;
            lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(7, 331);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(134, 20);
            lblFechaNacimiento.TabIndex = 15;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtFechaSalida
            // 
            dtFechaSalida.Location = new Point(590, 136);
            dtFechaSalida.Margin = new Padding(3, 4, 3, 4);
            dtFechaSalida.Name = "dtFechaSalida";
            dtFechaSalida.Size = new Size(228, 27);
            dtFechaSalida.TabIndex = 13;
            dtFechaSalida.ValueChanged += dtFechaSalida_ValueChanged;
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.Location = new Point(590, 84);
            dtFechaIngreso.Margin = new Padding(3, 4, 3, 4);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(228, 27);
            dtFechaIngreso.TabIndex = 12;
            // 
            // txtUnidadesaVendidas
            // 
            txtUnidadesaVendidas.Location = new Point(590, 236);
            txtUnidadesaVendidas.Margin = new Padding(3, 4, 3, 4);
            txtUnidadesaVendidas.Name = "txtUnidadesaVendidas";
            txtUnidadesaVendidas.Size = new Size(119, 27);
            txtUnidadesaVendidas.TabIndex = 15;
            txtUnidadesaVendidas.TextChanged += txtUnidadesaVendidas_TextChanged;
            txtUnidadesaVendidas.KeyPress += txtUnidadesaVendidas_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(590, 48);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(164, 27);
            txtTelefono.TabIndex = 11;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // cmSexo
            // 
            cmSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmSexo.FormattingEnabled = true;
            cmSexo.Items.AddRange(new object[] { "M", "F" });
            cmSexo.Location = new Point(141, 385);
            cmSexo.Margin = new Padding(3, 4, 3, 4);
            cmSexo.Name = "cmSexo";
            cmSexo.Size = new Size(138, 28);
            cmSexo.TabIndex = 9;
            // 
            // cmEstadoCivil
            // 
            cmEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmEstadoCivil.Enabled = false;
            cmEstadoCivil.FormattingEnabled = true;
            cmEstadoCivil.Items.AddRange(new object[] { "Solter@", "Casad@", "Viud@" });
            cmEstadoCivil.Location = new Point(590, 9);
            cmEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            cmEstadoCivil.Name = "cmEstadoCivil";
            cmEstadoCivil.Size = new Size(164, 28);
            cmEstadoCivil.TabIndex = 10;
            cmEstadoCivil.SelectedIndexChanged += cmEstadoCivil_SelectedIndexChanged;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActividad.Location = new Point(467, 192);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(75, 20);
            lblActividad.TabIndex = 26;
            lblActividad.Text = "Actividad";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaSalida.Location = new Point(463, 143);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(90, 20);
            lblFechaSalida.TabIndex = 27;
            lblFechaSalida.Text = "FechaSalida";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaIngreso.Location = new Point(455, 91);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(106, 20);
            lblFechaIngreso.TabIndex = 28;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // cmActividad
            // 
            cmActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmActividad.FormattingEnabled = true;
            cmActividad.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmActividad.Location = new Point(590, 184);
            cmActividad.Margin = new Padding(3, 4, 3, 4);
            cmActividad.Name = "cmActividad";
            cmActividad.Size = new Size(164, 28);
            cmActividad.TabIndex = 14;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Lucida Fax", 10F);
            btnNuevo.Location = new Point(578, 331);
            btnNuevo.Margin = new Padding(2, 3, 2, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 59);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Lucida Fax", 10F);
            btnCancelar.Location = new Point(718, 331);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 59);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Lucida Fax", 10F);
            btnGuardar.Location = new Point(455, 331);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 59);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Lucida Fax", 10F);
            btnEditar.Location = new Point(644, 396);
            btnEditar.Margin = new Padding(2, 3, 2, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 43);
            btnEditar.TabIndex = 30;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNumcedula
            // 
            txtNumcedula.Location = new Point(141, 56);
            txtNumcedula.Margin = new Padding(3, 4, 3, 4);
            txtNumcedula.Name = "txtNumcedula";
            txtNumcedula.Size = new Size(157, 27);
            txtNumcedula.TabIndex = 2;
            // 
            // lblNumCedula
            // 
            lblNumCedula.AutoSize = true;
            lblNumCedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumCedula.Location = new Point(27, 63);
            lblNumCedula.Name = "lblNumCedula";
            lblNumCedula.Size = new Size(81, 20);
            lblNumCedula.TabIndex = 35;
            lblNumCedula.Text = "No Cédula";
            // 
            // lblNumeroInss
            // 
            lblNumeroInss.AutoSize = true;
            lblNumeroInss.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroInss.Location = new Point(27, 102);
            lblNumeroInss.Name = "lblNumeroInss";
            lblNumeroInss.Size = new Size(67, 20);
            lblNumeroInss.TabIndex = 36;
            lblNumeroInss.Text = "No INSS";
            // 
            // lblNumruc
            // 
            lblNumruc.AutoSize = true;
            lblNumruc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumruc.Location = new Point(27, 140);
            lblNumruc.Name = "lblNumruc";
            lblNumruc.Size = new Size(64, 20);
            lblNumruc.TabIndex = 37;
            lblNumruc.Text = "No RUC";
            // 
            // txtNumruc
            // 
            txtNumruc.Location = new Point(141, 133);
            txtNumruc.Margin = new Padding(3, 4, 3, 4);
            txtNumruc.Name = "txtNumruc";
            txtNumruc.Size = new Size(157, 27);
            txtNumruc.TabIndex = 4;
            txtNumruc.KeyPress += txtNumruc_KeyPress;
            // 
            // txtNuminss
            // 
            txtNuminss.Location = new Point(141, 95);
            txtNuminss.Margin = new Padding(3, 4, 3, 4);
            txtNuminss.Name = "txtNuminss";
            txtNuminss.Size = new Size(157, 27);
            txtNuminss.TabIndex = 3;
            txtNuminss.KeyPress += txtNuminss_KeyPress;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(914, 657);
            Controls.Add(txtNuminss);
            Controls.Add(txtNumruc);
            Controls.Add(lblNumruc);
            Controls.Add(lblNumeroInss);
            Controls.Add(lblNumCedula);
            Controls.Add(txtNumcedula);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(cmActividad);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblFechaSalida);
            Controls.Add(lblActividad);
            Controls.Add(cmEstadoCivil);
            Controls.Add(cmSexo);
            Controls.Add(txtTelefono);
            Controls.Add(txtUnidadesaVendidas);
            Controls.Add(dtFechaIngreso);
            Controls.Add(dtFechaSalida);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblSexo);
            Controls.Add(lblEstadoCivil);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtEmpleado);
            Controls.Add(txtNombres);
            Controls.Add(lblApellidos);
            Controls.Add(lblCargo);
            Controls.Add(lblUnidadesVendidas);
            Controls.Add(cmCargo);
            Controls.Add(dtFechaNacimiento);
            Controls.Add(txtNoEmpleado);
            Controls.Add(lblNoEmpleado);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistrar";
            TransparencyKey = Color.Red;
            Load += frmRegistrar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblNoEmpleado;
        private TextBox txtNoEmpleado;
        private DateTimePicker dtFechaNacimiento;
        private ComboBox cmCargo;
        private Label lblUnidadesVendidas;
        private Label lblCargo;
        private Label lblApellidos;
        private Label txtNombres;
        private TextBox txtEmpleado;
        private TextBox txtApellidos;
        private Label lblTelefono;
        private Label lblEstadoCivil;
        private Label lblSexo;
        private Label lblFechaNacimiento;
        private DateTimePicker dtFechaSalida;
        private DateTimePicker dtFechaIngreso;
        private TextBox txtUnidadesaVendidas;
        private TextBox txtTelefono;
        private ComboBox cmSexo;
        private ComboBox cmEstadoCivil;
        private Label lblActividad;
        private Label lblFechaSalida;
        private Label lblFechaIngreso;
        private ComboBox cmActividad;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEditar;
        private TextBox txtNumcedula;
        private Label lblNumCedula;
        private Label lblNumeroInss;
        private Label lblNumruc;
        private TextBox txtNumruc;
        private TextBox txtNuminss;
    }
}