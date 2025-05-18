using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        // Lista simulando base de datos en memoria
        private static readonly List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nombre = "Juan Ramírez", Telefono = "123456789", Direccion = "L2.M3 Villas", Correo = "juanramirez@gmail.com" },
            new Cliente { Id = 2, Nombre = "Ana Torres", Telefono = "987654321", Direccion = "Lh.M1 San Raymundo", Correo = "anatorres@gmail.com" },
            new Cliente { Id = 3, Nombre = "Luis Pérez", Telefono = "456123789", Direccion = "Zona 10, Guatemala", Correo = "luisperez@gmail.com" },
            new Cliente { Id = 4, Nombre = "María García", Telefono = "555888777", Direccion = "Calle Real, Mixco", Correo = "mariagarcia@hotmail.com" },
            new Cliente { Id = 5, Nombre = "Carlos Soto", Telefono = "314159265", Direccion = "Av. Reforma, Zona 9", Correo = "carlossoto@yahoo.com" },
            new Cliente { Id = 6, Nombre = "Diana López", Telefono = "222333444", Direccion = "Col. Las Flores", Correo = "dianalopez@mail.com" },
            new Cliente { Id = 7, Nombre = "Fernando Cruz", Telefono = "987321456", Direccion = "Calle 5, Quetzaltenango", Correo = "fernandocruz@outlook.com" },
            new Cliente { Id = 8, Nombre = "Ana Morales", Telefono = "456789123", Direccion = "Avenida Central, Ciudad de Guatemala", Correo = "ana.morales@gmail.com" },
            new Cliente { Id = 9, Nombre = "José Ramírez", Telefono = "321654987", Direccion = "Zona 10, Mixco", Correo = "j.ramirez@hotmail.com" },
            new Cliente { Id = 10, Nombre = "Claudia Pérez", Telefono = "789123654", Direccion = "Boulevard Los Próceres, Guatemala", Correo = "claudia.perez@yahoo.com" },
            new Cliente { Id = 11, Nombre = "Luis Mendoza", Telefono = "963852741", Direccion = "Colonia El Maestro, Chiquimula", Correo = "lmendoza@gmail.com" },
            new Cliente { Id = 12, Nombre = "Verónica Díaz", Telefono = "258741369", Direccion = "Km 17.5 Carretera a El Salvador", Correo = "vero.diaz@outlook.com" },
            new Cliente { Id = 13, Nombre = "Ricardo López", Telefono = "741852963", Direccion = "Zona 1, Escuintla", Correo = "rlopez123@gmail.com" },
            new Cliente { Id = 14, Nombre = "Gabriela Estrada", Telefono = "159263478", Direccion = "Zona 3, Cobán", Correo = "gabrielae@gmail.com" },
            new Cliente { Id = 15, Nombre = "Santiago Herrera", Telefono = "357951486", Direccion = "Residenciales Las Luces, Antigua Guatemala", Correo = "sherrera@hotmail.com" }
        };

        // GET: /api/clientes
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(clientes);
        }

        // GET: /api/clientes/{id}
        [HttpGet("{id}")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            var cliente = clientes.Find(c => c.Id == id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }
    }
}