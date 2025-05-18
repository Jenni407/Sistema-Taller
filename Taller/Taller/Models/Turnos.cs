namespace TallerMecanico.Models
{
    public class Turno
    {
        public int Id_turno { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string Vehiculo { get; set; } = string.Empty;
        public string Servicio { get; set; } = string.Empty;
        public string Estado { get; set; } = "Pendiente";
    }
}
