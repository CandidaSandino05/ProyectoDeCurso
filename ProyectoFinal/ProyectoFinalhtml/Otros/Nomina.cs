using System.Text;

namespace ProyectoFinal.XD
{

    public class Nomina : Trabajadores
    {
        static List<Nomina> nom = new List<Nomina>();
        public Nomina() { }

        public static List<Nomina> Nom { get => nom; set => nom = value; }


        public double Salario { get; set; }
        public double salariob { get; set; }
        public double IngresoP { get; set; }
        public double sobre { get; set; }
        public double Monto { get; set; }
        public double unidadest { get; set; }
        public double deduciones { get; set; }
        public double InssLab { get; set; }
        public double IR { get; set; }
        public double Totals { get; set; }
        public double Totalb { get; set; }
        public double netoreci { get; set; }

        public static void Imp(string a)
        {

            string ruta = Path.Combine(a, "nomina.html");

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                List<string[]> encabezado = new List<string[]>
                {
                  new string[]
                  { "Número de empleado", "Número Cédula", "Número INSS", "Número RUC", "Nombres", "Apellidos",
                    "Cargo", "Fecha de nacimiento", "Sexo", "Estado civil", "Teléfono", "Fecha de ingreso",
                    "Fecha de salida", "Actividad", "Salario", "Unidades producidas", "Unidades vendidas",
                    "Total salarial", "INSS laboral", "IR", "Deducciones", "Total neto" 
                  }
                };


                sw.WriteLine(encabezado);

                List<string[]> datosConvertidos = ConvertirAListaDeStrings(Nom);
                

              
                sw.WriteLine(GenerarTablaHtml(encabezado, datosConvertidos));
                sw.Close();
            }
        }
        static List<string[]> ConvertirAListaDeStrings(List<Nomina> datos)
        {
            List<string[]> listaDeStrings = new List<string[]>();

            foreach (var nop in datos)
            {
                string[] empleado = new string[]
                {
                    nop.NumeroEmpleado.ToString(), nop.NumeroCedula, nop.NumeroInss.ToString(), nop.NumeroRUC.ToString(), nop.Nombre, nop.Apellidos,
                    nop.Cargo, nop.FechaNacimiento.ToString(), nop.sexo, nop.EstadoCiv, nop.telefono.ToString(), nop.FechaIngreso.ToString(),
                    nop.FechaSalida.ToString(), nop.actividad, nop.Salario.ToString(), nop.Unidadesp.ToString(), nop.unidadest.ToString(),
                    nop.Totals.ToString(), nop.InssLab.ToString(), nop.IR.ToString(), nop.deduciones.ToString(), nop.netoreci.ToString()
                };

                listaDeStrings.Add(empleado);
            }

            return listaDeStrings;
        }
        static string GenerarTablaHtml(List<string[]> encabezado, List<string[]> datos)
        {
            StringBuilder sb = new StringBuilder();

            // Comenzar la tabla
            sb.AppendLine("<table border='1'>");

            // Agregar encabezados
            sb.AppendLine("<tr>");
            foreach (string enc in encabezado[0])
            {
                sb.AppendLine($"<th>{enc}</th>");
            }
            sb.AppendLine("</tr>");

            // Agregar filas de datos
            foreach (var fila in datos)
            {
                sb.AppendLine("<tr>");
                foreach (var dato in fila)
                {
                    sb.AppendLine($"<td>{dato}</td>");
                }
                sb.AppendLine("</tr>");
            }

            // Finalizar la tabla
            sb.AppendLine("</table>");

            return sb.ToString();
        }

    }
}
