namespace MVCCRUD.Models
{
    public class MVCdata
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }

        public int IdDetalle { get; set; }
        public DateTime FechaContratacion { get; set; }
        public decimal Salario { get; set; }
        public string Rango { get; set; }
        public byte[] Curriculum { get; set; }
    }
}
