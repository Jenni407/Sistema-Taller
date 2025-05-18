using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/mecanicos")] 
    public class MecanicosController : ControllerBase
    {
        // Lista de mecánicos (simulando base de datos)
        private static readonly List<Mecanico> mecanicos = new List<Mecanico>
        {
            new Mecanico { Id = 1, Nombre = "Carlos Pérez", Especialidad = "Motor" },
            new Mecanico { Id = 2, Nombre = "Laura Díaz", Especialidad = "Electricidad" },
            new Mecanico { Id = 3, Nombre = "Juan Gómez", Especialidad = "Transmisión" },
            new Mecanico { Id = 4, Nombre = "Ana Torres", Especialidad = "Frenos" },
            new Mecanico { Id = 5, Nombre = "Luis Martínez", Especialidad = "Suspensión" },
            new Mecanico { Id = 6, Nombre = "Sofía López", Especialidad = "Alineación" },
            new Mecanico { Id = 7, Nombre = "Mario Castro", Especialidad = "Climatización" },
            new Mecanico { Id = 8, Nombre = "Elena Rojas", Especialidad = "Llantas y Rines" },
            new Mecanico { Id = 9, Nombre = "Carlos Méndez", Especialidad = "Transmisiones" },
            new Mecanico { Id = 10, Nombre = "Lucía Ortega", Especialidad = "Electricidad automotriz" },
            new Mecanico { Id = 11, Nombre = "Roberto Silva", Especialidad = "Frenos y suspensión" },
            new Mecanico { Id = 12, Nombre = "María Torres", Especialidad = "Diagnóstico computarizado" },
            new Mecanico { Id = 13, Nombre = "Jorge Ramírez", Especialidad = "Aire acondicionado" },
            new Mecanico { Id = 14, Nombre = "Fernanda López", Especialidad = "Motor y afinación" },
            new Mecanico { Id = 15, Nombre = "Luis Herrera", Especialidad = "Dirección hidráulica" },
            new Mecanico { Id = 16, Nombre = "Patricia Navarro", Especialidad = "Revisión general" }

        };

        // GET: /api/mecanicos
        [HttpGet]
        public IActionResult GetMecanicos()
        {
            return Ok(mecanicos); // Devuelve la lista completa
        }

        // GET: /api/mecanicos/2
        [HttpGet("{id}")]
        public IActionResult GetMecanico(int id)
        {
            var mecanico = mecanicos.Find(m => m.Id == id); // Busca por ID
            if (mecanico == null)
                return NotFound(); // 404 si no existe

            return Ok(mecanico); // 200 OK
        }

       
    }
}