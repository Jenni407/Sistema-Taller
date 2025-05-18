namespace TallerMecanico.Models
{
    public class Taller
    {
        public required string Id { get; set; } = string.Empty;
        public required string Nombre { get; set; } = string.Empty;
        public  required string Direccion { get; set; } = string.Empty;
        public required string Telefono { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string Horario { get; set; } = string.Empty;
        public required string Servicios { get; set; } = string.Empty;

    }
}
