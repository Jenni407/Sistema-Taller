using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/taller")] 
    public class TallerController : ControllerBase
    {
        // Lista simulada de talleres
        private static readonly List<Taller> talleres = new List<Taller>
        {
            new Taller
            {
Id = "1",
Nombre = "Taller El Buen Mecánico",
Direccion = "Calle 5 #123, Ciudad Taller",
Telefono = "123456789",
Email = "info@elbuenmecanico.com",
Horario = "Lunes a Sábado 8am - 6pm",
Servicios = "Mecánica general, Frenos, Alineación"
            },
            new Taller {
   Id = "2",
   Nombre = "AutoFix Express",
   Direccion = "Avenida Reforma 10-55, Zona 9, Guatemala",
   Telefono = "22334455",
   Email = "contacto@autofix.com",
   Horario = "Lunes a Viernes 7am - 5pm",
   Servicios = "Cambio de aceite, Electricidad automotriz, Scanner"
},

new Taller {
   Id = "3",
   Nombre = "Motores y Más",
   Direccion = "Km 14 Carretera a El Salvador, Plaza Motor, Local 4",
   Telefono = "55223311",
   Email = "servicio@motoresymas.gt",
   Horario = "Lunes a Sábado 8am - 6pm",
   Servicios = "Reparación de motor, Frenos, Suspensión"
},

new Taller {
   Id = "4",
   Nombre = "Taller La Recta",
   Direccion = "Zona 1, Calle Real #45, Chimaltenango",
   Telefono = "456789123",
   Email = "tallerlarecta@gmail.com",
   Horario = "Lunes a Viernes 9am - 6pm",
   Servicios = "Alineación, Balanceo, Revisión general"
},

new Taller {
   Id = "5",
   Nombre = "Ruedas y Rines GT",
   Direccion = "Zona 12, Bulevar Villa Hermosa, San Miguel Petapa",
   Telefono = "33445566",
   Email = "info@ruedasyriens.com",
   Horario = "Lunes a Domingo 8am - 5pm",
   Servicios = "Llantas, Rines, Suspensión deportiva"
}

        };

        // GET: /api/taller
        [HttpGet]
        public ActionResult<IEnumerable<Taller>> GetTalleres()
        {
            return Ok(talleres); // Devuelve todos los talleres
        }

        // GET: /api/taller/{id}
        [HttpGet("{id}")]
        public ActionResult<Taller> GetTaller(string id)
        {
            var taller = talleres.Find(t => t.Id == id);
            if (taller == null)
                return NotFound(); // Retorna 404 si no existe

            return Ok(taller); // Retorna el taller encontrado
        }
    }
}