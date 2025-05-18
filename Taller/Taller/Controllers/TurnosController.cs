using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;
using System.Collections.Generic;

namespace TallerMecanico.Controllers
{
    [ApiController]
    [Route("api/turnos")]  
    public class TurnosController : ControllerBase
    {
        private static readonly List<Turno> turnos = new List<Turno>
        {
            new Turno { Id_turno = 1, Cliente= "Juan Ramirez", Vehiculo = "Honda Civic", Fecha = DateTime.Today.AddDays(1), Hora ="10:00", Servicio= "Cambio de aceite", Estado ="Pendiente" },
            new Turno { Id_turno = 2, Cliente= "Ana Torres", Vehiculo = "Toyota Corolla", Fecha = DateTime.Today.AddDays(2), Hora ="11:00", Servicio= "Revisión general", Estado= "Pendiente" },
            new Turno { Id_turno = 3, Cliente= "Luis Pérez", Vehiculo = "Honda Civic", Fecha = DateTime.Today.AddDays(1), Hora = "09:00", Servicio = "Cambio de aceite", Estado = "Confirmado" },
            new Turno { Id_turno = 4, Cliente= "Claudia Ramírez", Vehiculo = "Hyundai Tucson", Fecha = DateTime.Today.AddDays(3), Hora = "14:00", Servicio = "Frenos", Estado = "Pendiente" },
            new Turno { Id_turno = 5, Cliente= "Carlos Gómez", Vehiculo = "Mazda 3", Fecha = DateTime.Today, Hora = "16:30", Servicio = "Alineación", Estado = "En proceso" },
            new Turno { Id_turno = 6, Cliente= "Verónica Díaz", Vehiculo = "Nissan Sentra", Fecha = DateTime.Today.AddDays(4), Hora = "10:30", Servicio = "Revisión general", Estado = "Pendiente" },
            new Turno { Id_turno = 7, Cliente= "Fernando Cruz", Vehiculo = "Chevrolet Aveo", Fecha = DateTime.Today.AddDays(-1), Hora = "13:00", Servicio = "Cambio de bujías", Estado = "Finalizado" },
            new Turno { Id_turno = 8, Cliente= "Gabriela Estrada", Vehiculo = "Kia Sportage", Fecha = DateTime.Today.AddDays(2), Hora = "08:00", Servicio = "Escaneo computarizado", Estado = "Confirmado" },
            new Turno { Id_turno = 9, Cliente= "Ricardo López", Vehiculo = "Volkswagen Jetta", Fecha = DateTime.Today.AddDays(5), Hora = "12:30", Servicio = "Suspensión", Estado = "Pendiente" },
            new Turno { Id_turno = 10, Cliente= "Patricia Navarro", Vehiculo = "Ford Escape", Fecha = DateTime.Today, Hora = "11:15", Servicio = "Limpieza de inyectores", Estado = "En proceso" },
            new Turno { Id_turno = 11, Cliente= "Jorge Ramírez", Vehiculo = "Renault Duster", Fecha = DateTime.Today.AddDays(3), Hora = "15:00", Servicio = "Aire acondicionado", Estado = "Pendiente" },
            new Turno { Id_turno = 12, Cliente= "Lucía Ortega", Vehiculo = "Toyota Hilux", Fecha = DateTime.Today.AddDays(1), Hora = "09:45", Servicio = "Electricidad automotriz", Estado = "Confirmado" },
            new Turno { Id_turno = 13, Cliente= "María Torres", Vehiculo = "Suzuki Swift", Fecha = DateTime.Today.AddDays(2), Hora = "10:00", Servicio = "Cambio de correa", Estado = "Pendiente" },
            new Turno { Id_turno = 14, Cliente= "Santiago Herrera", Vehiculo = "Isuzu D-Max", Fecha = DateTime.Today.AddDays(6), Hora = "13:45", Servicio = "Diagnóstico", Estado = "Pendiente" },
            new Turno { Id_turno = 15, Cliente= "Elena Rojas", Vehiculo = "Mitsubishi Lancer", Fecha = DateTime.Today.AddDays(2), Hora = "12:00", Servicio = "Llantas y rines", Estado = "Confirmado" }
        };

        // GET: api/turnos
        [HttpGet]
        public ActionResult<IEnumerable<Turno>> GetAllTurnos()
        {
            return Ok(turnos);
        }

        // GET: api/turnos/1
        [HttpGet("{id}")]
        public ActionResult<Turno> GetTurnoById(int id)
        {
            var turno = turnos.Find(t => t.Id_turno == id);
            if (turno == null)
                return NotFound();
            return Ok(turno);
        }
    }
}