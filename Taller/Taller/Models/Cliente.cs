namespace TallerMecanico.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nombre { get; set; } = string.Empty;
        public required string Telefono { get; set; } = string.Empty;
        public required string Direccion { get; set; } = string.Empty;
        public required string Correo { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

    }
}
