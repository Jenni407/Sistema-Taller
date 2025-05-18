using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/servicios")]
    public class ServiciosController : ControllerBase
    {
        // Lista simulada de servicios
        private static readonly List<Servicio> servicios = new List<Servicio>
        {
            new Servicio { Id = 1, Nombre = "Cambio de aceite", Descripcion = "Incluye aceite y filtro", Precio = 4500, Duracion = 30 },
            new Servicio { Id = 2, Nombre = "Alineación y balanceo", Descripcion = "Alineación de ejes y balanceo de ruedas", Precio = 6500, Duracion = 45 },
            new Servicio { Id = 3, Nombre = "Revisión de frenos", Descripcion = "Inspección completa del sistema de frenos", Precio = 7000, Duracion = 60 },
            new Servicio { Id = 4, Nombre = "Diagnóstico electrónico", Descripcion = "Escaneo y lectura de códigos OBD", Precio = 5000, Duracion = 40 },
            new Servicio { Id = 5, Nombre = "Lavado completo", Descripcion = "Lavado exterior e interior", Precio = 3000, Duracion = 25 },
            new Servicio { Id = 6, Nombre = "Cambio de bujías", Descripcion = "Reemplazo de bujías del motor", Precio = 3800, Duracion = 35 },
            new Servicio { Id = 7, Nombre = "Alineación y balanceo", Descripcion = "Ajuste del ángulo de las ruedas y balanceo de neumáticos", Precio = 2500, Duracion = 45 },
            new Servicio { Id = 8, Nombre = "Cambio de aceite", Descripcion = "Sustitución del aceite del motor y filtro", Precio = 1800, Duracion = 30 },
            new Servicio { Id = 9, Nombre = "Revisión de frenos", Descripcion = "Inspección y ajuste del sistema de frenos", Precio = 2900, Duracion = 40 },
            new Servicio { Id = 10, Nombre = "Carga de aire acondicionado", Descripcion = "Recarga de gas refrigerante y revisión del sistema", Precio = 3200, Duracion = 50 },
            new Servicio { Id = 11, Nombre = "Escaneo computarizado", Descripcion = "Diagnóstico electrónico del vehículo", Precio = 1500, Duracion = 25 },
            new Servicio { Id = 12, Nombre = "Cambio de correa de distribución", Descripcion = "Reemplazo completo de la correa de distribución", Precio = 8200, Duracion = 120 },
            new Servicio { Id = 13, Nombre = "Limpieza de inyectores", Descripcion = "Limpieza profunda de los inyectores de combustible", Precio = 4000, Duracion = 60 }
        };

        // GET: /api/servicios
        [HttpGet]
        public IActionResult GetServicios()
        {
            return Ok(servicios); // Devuelve todos los servicios
        }

        // GET: /api/servicios/3
        [HttpGet("{id}")]
        public IActionResult GetServicio(int id)
        {
            var servicio = servicios.Find(s => s.Id == id);
            if (servicio == null)
                return NotFound();

            return Ok(servicio);
        }
    }
}