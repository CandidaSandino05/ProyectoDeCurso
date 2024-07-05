using ProyectoFinal.XD;
using System.Data;

namespace ProyectoFinal.MAS_FORMS
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        public void btNuevo(string b)
        {
            switch (b)
            {
                case "Nuevo":
                    this.txtNoEmpleado.Enabled = true;
                    this.txtNumcedula.Enabled = true;
                    this.txtNuminss.Enabled = true;
                    this.txtNumruc.Enabled = true;
                    this.txtEmpleado.Enabled = true;
                    this.txtApellidos.Enabled = true;
                    this.cmCargo.Enabled = true;
                    this.dtFechaNacimiento.Enabled = true;
                    this.cmSexo.Enabled = true;
                    this.cmEstadoCivil.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.dtFechaIngreso.Enabled = true;
                    this.dtFechaSalida.Enabled = true;
                    this.cmActividad.Enabled = true;
                    this.txtUnidadesaVendidas.Enabled = true;
                    break;


                case "Bloqueado":
                    this.txtNoEmpleado.Enabled = false;
                    this.txtNumcedula.Enabled = false;
                    this.txtNuminss.Enabled = false;
                    this.txtNumruc.Enabled = false;
                    this.txtEmpleado.Enabled = false;
                    this.txtApellidos.Enabled = false;
                    this.cmCargo.Enabled = false;
                    this.dtFechaNacimiento.Enabled = false;
                    this.cmSexo.Enabled = false;
                    this.cmEstadoCivil.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.dtFechaIngreso.Enabled = false;
                    this.dtFechaSalida.Enabled = false;
                    this.cmActividad.Enabled = false;
                    this.txtUnidadesaVendidas.Enabled = false;
                    break;

            }
        }

        public void limpiar()
        {
            this.txtNoEmpleado.Text = string.Empty;
            this.txtNumcedula.Text = string.Empty;
            this.txtNuminss.Text = string.Empty;
            this.txtNumruc.Text = string.Empty;
            this.txtEmpleado.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.cmCargo.Text = string.Empty;
            this.dtFechaNacimiento.Value = DateTime.Now;
            this.cmSexo.Text = string.Empty;
            this.cmEstadoCivil.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.dtFechaIngreso.Value = DateTime.Now;
            this.dtFechaSalida.Value = DateTime.Now;
            this.cmActividad.Text = string.Empty;
            this.txtUnidadesaVendidas.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btNuevo("Nuevo");

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            btNuevo("Bloqueado");
            imprimir();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtEmpleado.Text != "" && this.txtApellidos.Text != "" &&
                this.txtNoEmpleado.Text != "" && this.cmCargo.Text != "" &&
                this.txtUnidadesaVendidas.Text != "")
            {
                Trabajadores empleados = new Trabajadores();
                empleados.NumeroCedula = this.txtNumcedula.Text;
                empleados.NumeroInss = Convert.ToInt32(this.txtNuminss.Text);
                empleados.NumeroRUC = Convert.ToInt32(this.txtNumruc.Text);
                empleados.Nombre = this.txtEmpleado.Text;
                empleados.Apellidos = this.txtApellidos.Text;
                empleados.NumeroEmpleado = Convert.ToInt32(this.txtNoEmpleado.Text);
                empleados.Cargo = this.cmCargo.Text;
                empleados.FechaNacimiento = this.dtFechaNacimiento.Value;
                empleados.sexo = this.cmSexo.Text;
                empleados.EstadoCiv = this.cmEstadoCivil.Text;
                empleados.telefono = Convert.ToInt32(this.txtTelefono.Text);
                empleados.FechaIngreso = this.dtFechaIngreso.Value;
                empleados.FechaSalida = this.dtFechaSalida.Value;
                empleados.actividad = this.cmActividad.Text;
                empleados.Unidadesp = Convert.ToInt32(this.txtUnidadesaVendidas.Text);




                Trabajadores.Tr.Add(empleados);

                btNuevo("Bloqueado");
                imprimir();
                limpiar();
                MessageBox.Show("Registro guardado exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btNuevo("Bloqueado");
            limpiar();
            MessageBox.Show("Cancelando la operación.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void imprimir()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Numero Empleado");
            data.Columns.Add("Numero Cedula");
            data.Columns.Add("Numero INSS");
            data.Columns.Add("Numero RUC");
            data.Columns.Add("Nombres");
            data.Columns.Add("Apellidos");
            data.Columns.Add("Cargo");
            data.Columns.Add("Fecha Nacimiento");
            data.Columns.Add("Sexo");
            data.Columns.Add("Estado Civil");
            data.Columns.Add("Telefono");
            data.Columns.Add("Fecha Ingreso");
            data.Columns.Add("Fecha Salida");
            data.Columns.Add("Actividad");
            data.Columns.Add("Unidades Vendidas");
            foreach (Trabajadores trabaja in Trabajadores.Tr)
            {
                data.Rows.Add(new Object[] {trabaja.NumeroEmpleado,trabaja.NumeroCedula,trabaja.NumeroInss,trabaja.NumeroRUC,trabaja.Nombre,
                    trabaja.Apellidos,trabaja.Cargo,trabaja.FechaNacimiento,trabaja.sexo,trabaja.EstadoCiv,trabaja.telefono,
                    trabaja.FechaIngreso,trabaja.FechaSalida,trabaja.actividad,trabaja.Unidadesp
               });

            }

            this.dataGridView1.DataSource = data;
        }
        private Trabajadores empleadoSeleccionado;
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (empleadoSeleccionado != null)
            {
                //Solo podes editar el numeroempleado,no cedula,no inss,no ruc,nombre,apellidos,telefono,actividad
                empleadoSeleccionado.NumeroEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
                empleadoSeleccionado.NumeroCedula = txtNumcedula.Text;
                empleadoSeleccionado.NumeroInss = Convert.ToInt32(txtNuminss.Text);
                empleadoSeleccionado.NumeroRUC = Convert.ToInt32(txtNumruc.Text);
                empleadoSeleccionado.Nombre = txtEmpleado.Text;
                empleadoSeleccionado.Apellidos = txtApellidos.Text;
                empleadoSeleccionado.telefono = Convert.ToInt32(txtTelefono.Text);
                empleadoSeleccionado.actividad = cmActividad.Text;


                empleadoSeleccionado = null;

                imprimir();

                limpiar();

                MessageBox.Show("Registro editado exitosamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                txtNumcedula.Text = row.Cells["Numero Cedula"].Value.ToString();
                txtNuminss.Text = row.Cells["Numero INSS"].Value.ToString();
                txtNumruc.Text = row.Cells["Numero RUC"].Value.ToString();
                txtNoEmpleado.Text = row.Cells["Numero Empleado"].Value.ToString();
                txtEmpleado.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                //cmCargo.Text = row.Cells["Cargo"].Value.ToString();
                //cmSexo.Text = row.Cells["Sexo"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();

                empleadoSeleccionado = Trabajadores.Tr.Find(t => t.NumeroEmpleado == Convert.ToInt32(txtNoEmpleado.Text));

                btNuevo("Nuevo");

                btnEditar.Enabled = true;
            }


        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros enteros, no decimales ni letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {//Solo para que acepte letras 
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este evento es para que solo acepte numeros enteros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números enteros");
            }
        }
        //Este evento sirve para numeros enteros y decimales 
        private void txtUnidadesaVendidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void cmEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números enteros");
            }
        }

        private void txtNuminss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números enteros");
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidadesaVendidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnidadesVendidas_Click(object sender, EventArgs e)
        {

        }

        private void txtNoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

