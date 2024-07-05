using ProyectoFinal.XD;
using System.Data;

namespace ProyectoFinal.MAS_FORMS
{
    public partial class frmCalculoIR : Form
    {
        public frmCalculoIR()
        {
            InitializeComponent();
        }

        int porcentaje = 17;
        double Sobre = 8333.33;
        public static void CalculoIR()
        {
            Nomina.Nom = new List<Nomina>();

            foreach (Trabajadores nose in Trabajadores.Tr.ToList())
            {

                switch (nose.Cargo)
                {
                    case "Gerente General":
                        Nomina n = new Nomina();
                        n.NumeroEmpleado = nose.NumeroEmpleado;
                        n.NumeroCedula = nose.NumeroCedula;
                        n.NumeroInss = nose.NumeroInss;
                        n.NumeroRUC = nose.NumeroRUC;
                        n.Nombre = nose.Nombre;
                        n.Apellidos = nose.Apellidos;
                        n.Cargo = nose.Cargo;
                        n.FechaNacimiento = nose.FechaNacimiento;
                        n.sexo = nose.sexo;
                        n.EstadoCiv = nose.EstadoCiv;
                        n.telefono = nose.telefono;
                        n.FechaIngreso = nose.FechaIngreso;
                        n.FechaSalida = nose.FechaSalida;
                        n.actividad = nose.actividad;
                        n.Unidadesp = nose.Unidadesp;
                        n.unidadest = n.Unidadesp * 0;
                        //Salario fijo contando que tiene experiencia de 3-5 años
                        n.Salario = 56440;
                        n.Totals = n.Salario + n.unidadest;
                        n.InssLab = n.Totals * 0.07;
                        n.sobre = 8333.33;
                        n.Totalb = n.Totals - n.InssLab;
                        n.Monto = n.Totalb - n.sobre;
                        n.IR = n.Monto * 0.17;
                        Nomina.Nom.Add(n);



                        break;

                    case
                        "Contador":
                        Nomina p = new Nomina();
                        p.NumeroEmpleado = nose.NumeroEmpleado;
                        p.NumeroCedula = nose.NumeroCedula;
                        p.NumeroInss = nose.NumeroInss;
                        p.NumeroRUC = nose.NumeroRUC;
                        p.Nombre = nose.Nombre;
                        p.Apellidos = nose.Apellidos;
                        p.Cargo = nose.Cargo;
                        p.FechaNacimiento = nose.FechaNacimiento;
                        p.sexo = nose.sexo;
                        p.EstadoCiv = nose.EstadoCiv;
                        p.telefono = nose.telefono;
                        p.FechaIngreso = nose.FechaIngreso;
                        p.FechaSalida = nose.FechaSalida;
                        p.actividad = nose.actividad;
                        p.Unidadesp = nose.Unidadesp;
                        p.unidadest = p.Unidadesp * 0;
                        //Teniendo en cuenta que es una pequeña y mediana empresa PYMES
                        p.Salario = 35224;
                        p.Totals = p.Salario + p.unidadest;
                        p.InssLab = p.Totals * 0.07;
                        p.sobre = 8333.33;
                        p.Totalb = p.Totals - p.InssLab;
                        p.Monto = p.Totalb - p.sobre;
                        p.IR = p.Monto * 0.17;

                        Nomina.Nom.Add(p);
                        break;

                    case
                        "Director de RR.HH":
                        Nomina a = new Nomina();
                        a.NumeroEmpleado = nose.NumeroEmpleado;
                        a.NumeroCedula = nose.NumeroCedula;
                        a.NumeroInss = nose.NumeroInss;
                        a.NumeroRUC = nose.NumeroRUC;
                        a.Nombre = nose.Nombre;
                        a.Apellidos = nose.Apellidos;
                        a.Cargo = nose.Cargo;
                        a.FechaNacimiento = nose.FechaNacimiento;
                        a.sexo = nose.sexo;
                        a.EstadoCiv = nose.EstadoCiv;
                        a.telefono = nose.telefono;
                        a.FechaIngreso = nose.FechaIngreso;
                        a.FechaSalida = nose.FechaSalida;
                        a.actividad = nose.actividad;
                        a.Unidadesp = nose.Unidadesp;
                        a.unidadest = a.Unidadesp * 1;
                        // De 3-5 años de experiencia en una PYMES
                        a.Salario = 25444;
                        a.Totals = a.Salario + a.unidadest;
                        a.InssLab = a.Totals * 0.07;
                        a.sobre = 8333.33;
                        a.Totalb = a.Totals - a.InssLab;
                        a.Monto = a.Totalb - a.sobre;
                        a.IR = a.Monto * 0.17;

                        break;

                    case
                        "Supervisor":
                        Nomina o = new Nomina();
                        o.NumeroEmpleado = nose.NumeroEmpleado;
                        o.NumeroCedula = nose.NumeroCedula;
                        o.NumeroInss = nose.NumeroInss;
                        o.NumeroRUC = nose.NumeroRUC;
                        o.Nombre = nose.Nombre;
                        o.Apellidos = nose.Apellidos;
                        o.Cargo = nose.Cargo;
                        o.FechaNacimiento = nose.FechaNacimiento;
                        o.sexo = nose.sexo;
                        o.EstadoCiv = nose.EstadoCiv;
                        o.telefono = nose.telefono;
                        o.FechaIngreso = nose.FechaIngreso;
                        o.FechaSalida = nose.FechaSalida;
                        o.actividad = nose.actividad;
                        o.Unidadesp = nose.Unidadesp;
                        o.unidadest = o.Unidadesp * 20; //en forma de comisiones , viaticos , etc 
                        o.Salario = 28500;
                        o.Totals = o.Salario + o.unidadest;
                        o.InssLab = o.Totals * 0.07;
                        o.sobre = 8333.33;
                        o.Totalb = o.Totals - o.InssLab;
                        o.Monto = o.Totalb - o.sobre;
                        o.IR = o.Monto * 0.17;

                        Nomina.Nom.Add(o);
                        break;



                        Nomina.Nom.Add(n);
                        Nomina.Nom.Add(a);
                        Nomina.Nom.Add(p);
                        Nomina.Nom.Add(o);

                    default:
                        MessageBox.Show("EL Cargo no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                }

            }

        }
        public void ImprimirIR()
        {
            DataTable ir = new DataTable();
            ir.Columns.Add("Numero Empleado");
            ir.Columns.Add("Numero Cedula");
            ir.Columns.Add("Numero Inss");
            ir.Columns.Add("Numero RUC");
            ir.Columns.Add("Nombre");
            ir.Columns.Add("Apellidos");
            ir.Columns.Add("Cargo");
            ir.Columns.Add("Fecha Nacimiento");
            ir.Columns.Add("Sexo");
            ir.Columns.Add("Estado Civil");
            ir.Columns.Add("telefono");
            ir.Columns.Add("Fecha Ingreso");
            ir.Columns.Add("FechaSalida");
            ir.Columns.Add("Actividad");
            ir.Columns.Add("Salario");
            ir.Columns.Add("Sobreexceso");
            ir.Columns.Add("Monto");
            ir.Columns.Add("Rentencion del IR");

            foreach (Nomina a in Nomina.Nom)
            {
                ir.Rows.Add(new Object[]
                {                    a.NumeroEmpleado,a.NumeroCedula,a.NumeroInss,a.NumeroRUC,a.Nombre,a.Apellidos,a.Cargo,a.FechaNacimiento,a.sexo,a.EstadoCiv,
                    a.telefono,a.FechaIngreso,a.FechaSalida,a.actividad,a.Totalb,a.sobre,a.Monto,a.IR
                });
            }
            this.dgir.DataSource = ir;



        }

        private void frmCalculoIR_Load(object sender, EventArgs e)
        {
            CalculoIR();
            ImprimirIR();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
