using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    // Este atributo convierte la clase en un controlador de API REST
    [ApiController]

  
    [Route("api/vehiculos")]
    public class VehiculosController : ControllerBase
    {
        // Lista fija simulando base de datos en memoria
        private static readonly List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo { Id = 1, Marca = "Toyota", Modelo = "Corolla", Placa = "ABC123", Color = "Blanco" },
            new Vehiculo { Id = 2, Marca = "Ford", Modelo = "Focus", Placa = "DEF456", Color = "Corinto" },
            new Vehiculo { Id = 3, Marca = "Chevrolet", Modelo = "Sonic", Placa = "GHI789", Color = "Rojo" },
            new Vehiculo { Id = 4, Marca = "Nissan", Modelo = "Versa", Placa = "JKL012", Color = "Azul" },
            new Vehiculo { Id = 5, Marca = "Hyundai", Modelo = "Elantra", Placa = "MNO345", Color = "Verde" },
            new Vehiculo { Id = 6, Marca = "Toyota", Modelo = "Corolla", Placa = "ABC123", Color = "Blanco" },
            new Vehiculo { Id = 7, Marca = "Honda", Modelo = "Civic", Placa = "XYZ789", Color = "Gris" },
            new Vehiculo { Id = 8, Marca = "Nissan", Modelo = "Sentra", Placa = "DEF456", Color = "Rojo" },
            new Vehiculo { Id = 9, Marca = "Mazda", Modelo = "3", Placa = "GHI012", Color = "Negro" },
            new Vehiculo { Id = 10, Marca = "Kia", Modelo = "Sportage", Placa = "JKL678", Color = "Azul" },
            new Vehiculo { Id = 11, Marca = "Ford", Modelo = "Escape", Placa = "PQR234", Color = "Plateado" },
            new Vehiculo { Id = 12, Marca = "Chevrolet", Modelo = "Aveo", Placa = "TUV901", Color = "Amarillo" },
            new Vehiculo { Id = 13, Marca = "Volkswagen", Modelo = "Jetta", Placa = "LMN567", Color = "Bordó" }
        };

        // GET: /api/vehiculos
        // Devuelve la lista completa de vehículos
        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> GetVehiculos()
        {
            return Ok(vehiculos);
        }

        // GET: /api/vehiculos/3
        // Devuelve un solo vehículo según su ID
        [HttpGet("{id}")]
        public ActionResult<Vehiculo> GetVehiculoById(int id)
        {
            var vehiculo = vehiculos.Find(v => v.Id == id);
            if (vehiculo == null)
                return NotFound(); // 404 si no se encuentra
            return Ok(vehiculo);   // 200 con el vehículo encontrado
        }
    }
}