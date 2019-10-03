using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parqueadero.domain.model;
using Parqueadero.domain.services.implementacion;

namespace Parqueadero.infrastructure.restcontroller
{
    [Route("/api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly VehiculoService vehiculoService;

        public VehiculoController(VehiculoService vehiculoService)
        {
            this.vehiculoService = vehiculoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VehiculoDto>> obtenerTodos()
        {
            return vehiculoService.obtenerTodos();
        }

        [HttpPost]
        public void crearVehiculo([FromBody] VehiculoDto vehiculoDto)
        {
            vehiculoService.crearVehiculo(vehiculoDto);
        }

        [HttpPut]
        public void modificarVehiculo([FromBody] VehiculoDto vehiculoDto)
        {
            vehiculoService.modificarVehiculo(vehiculoDto);
        }

        [HttpDelete]
        public void eliminarVehiculo([FromBody] VehiculoDto vehiculoDto)
        {
            vehiculoService.eliminarVehiculo(vehiculoDto);
        }
    }
}
