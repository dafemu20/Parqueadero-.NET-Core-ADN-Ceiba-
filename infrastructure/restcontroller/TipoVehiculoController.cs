using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parqueadero.domain.model;
using Parqueadero.domain.services;
using Parqueadero.domain.services.implementacion;

namespace Parqueadero.infrastructure.restcontroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVehiculoController: ControllerBase
    {

        private readonly ITipoVehiculoService tipoVehiculoService;

        public TipoVehiculoController(ITipoVehiculoService tipoVehiculoService)
        {
            this.tipoVehiculoService = tipoVehiculoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoVehiculoDto>> obtenerTodos()
        {
            return tipoVehiculoService.obtenerTodos();
        }

        [HttpGet("{id}")]
        public ActionResult<TipoVehiculoDto> obtenerPorId(int id)
        {
            return tipoVehiculoService.obtenerPorId(id);
        }

        [HttpPost]
        public void crearTipoVehiculo([FromBody] TipoVehiculoDto tipoVehiculoDto)
        {
            tipoVehiculoService.crearTipoVehiculo(tipoVehiculoDto);
        }

        [HttpPut]
        public void modificarTipoVehiculo([FromBody] TipoVehiculoDto tipoVehiculoDto)
        {
            tipoVehiculoService.modificarTipoVehiculo(tipoVehiculoDto);
        }

        [HttpDelete]
        public void eliminarTipoVehiculo([FromBody] TipoVehiculoDto tipoVehiculoDto)
        {
            tipoVehiculoService.eliminarTipoVehiculo(tipoVehiculoDto);
        }
    }
}
