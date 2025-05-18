using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/repuestos")]
    public class RepuestosController : ControllerBase
    {
        // Lista estática simulando los datos
        private static readonly List<Repuesto> repuestos = new List<Repuesto>
        {
            new Repuesto { Id = 1, Nombre = "Filtro de aceite", Precio = 1500, Cantidad = 10 },
            new Repuesto { Id = 2, Nombre = "Bujía", Precio = 500, Cantidad = 30 },
            new Repuesto { Id = 3, Nombre = "Pastillas de freno", Precio = 2500, Cantidad = 15 },
            new Repuesto { Id = 4, Nombre = "Correa de distribución", Precio = 4500, Cantidad = 8 },
            new Repuesto { Id = 5, Nombre = "Líquido de frenos", Precio = 1200, Cantidad = 20 },
            new Repuesto { Id = 6, Nombre = "Filtro de aceite", Precio = 450, Cantidad = 35 },
            new Repuesto { Id = 7, Nombre = "Bujías", Precio = 950, Cantidad = 50 },
            new Repuesto { Id = 8, Nombre = "Pastillas de freno", Precio = 1800, Cantidad = 25 },
            new Repuesto { Id = 9, Nombre = "Aceite para motor", Precio = 750, Cantidad = 60 },
            new Repuesto { Id = 10, Nombre = "Correa de distribución", Precio = 2200, Cantidad = 15 },
            new Repuesto { Id = 11, Nombre = "Amortiguadores", Precio = 3200, Cantidad = 10 },
            new Repuesto { Id = 12, Nombre = "Filtro de aire", Precio = 500, Cantidad = 40 },
            new Repuesto { Id = 13, Nombre = "Lámpara delantera", Precio = 1450, Cantidad = 18 }



        };

        // GET: /api/repuestos
        [HttpGet]
        public ActionResult<IEnumerable<Repuesto>> GetRepuestos()
        {
            return Ok(repuestos); // Devuelve la lista completa
        }

        // GET: /api/repuestos/{id}
        [HttpGet("{id}")]
        public ActionResult<Repuesto> GetRepuesto(int id)
        {
            var repuesto = repuestos.Find(r => r.Id == id);
            if (repuesto == null)
                return NotFound();  // 404 si no existe

            return Ok(repuesto);   // 200 con el repuesto
        }
    }
}