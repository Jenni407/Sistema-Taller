using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/facturas")] 
    public class FacturasController : ControllerBase
    {
        // Lista simulada de facturas
        private static readonly List<Factura> facturas = new List<Factura>
        {
            new Factura { Id = 1, Cliente = "Juan Ramírez", Fecha = DateTime.Now.AddDays(-1), Total = 12500.50m },
            new Factura { Id = 2, Cliente = "Ana Torres", Fecha = DateTime.Now.AddDays(-2), Total = 8500.00m },
            new Factura { Id = 3, Cliente = "Carlos Pérez", Fecha = DateTime.Now.AddDays(-3), Total = 10500.75m },
            new Factura { Id = 4, Cliente = "Ana Morales", Fecha = DateTime.Now.AddDays(-1), Total = 3520.00m },
            new Factura { Id = 5, Cliente = "Luis Mendoza", Fecha = DateTime.Now.AddDays(-7), Total = 7800.45m },
            new Factura { Id = 6, Cliente = "Verónica Díaz", Fecha = DateTime.Now.AddDays(-2), Total = 12850.99m },
            new Factura { Id = 7, Cliente = "José Ramírez", Fecha = DateTime.Now.AddDays(-10), Total = 4999.99m },
            new Factura { Id = 8, Cliente = "Claudia Pérez", Fecha = DateTime.Now.AddDays(-5), Total = 6200.00m },
            new Factura { Id = 9, Cliente = "Ricardo López", Fecha = DateTime.Now.AddDays(-4), Total = 9450.75m },
            new Factura { Id = 10, Cliente = "Gabriela Estrada", Fecha = DateTime.Now.AddDays(-6), Total = 7100.30m },
            new Factura { Id = 11, Cliente = "Santiago Herrera", Fecha = DateTime.Now.AddDays(-8), Total = 3300.00m }
        };

        // GET: /api/facturas
        [HttpGet]
        public ActionResult<IEnumerable<Factura>> GetFacturas()
        {
            return Ok(facturas); // Retorna todas las facturas
        }

        // GET: /api/facturas/{id}
        [HttpGet("{id}")]
        public ActionResult<Factura> GetFactura(int id)
        {
            var factura = facturas.Find(f => f.Id == id);
            if (factura == null)
                return NotFound(); // 404 si no existe

            return Ok(factura); // 200 con la factura encontrada
        }
    }
}