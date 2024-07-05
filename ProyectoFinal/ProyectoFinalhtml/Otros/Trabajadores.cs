namespace ProyectoFinal.XD
{
    public class Trabajadores
    {
        static List<Trabajadores> tr = new List<Trabajadores>();

        public Trabajadores() { }

        public static List<Trabajadores> Tr { get => tr; set => tr = value; }
        public int NumeroEmpleado { get; set; }
        public string NumeroCedula { get; set; }
        public int NumeroInss { get; set; }
        public int NumeroRUC { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string Cargo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string EstadoCiv { get; set; }
        public int telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Unidadesp { get; set; }
        public string actividad { get; set; }



    }
}
