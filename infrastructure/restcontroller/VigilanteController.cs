using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parqueadero.domain.model;
using Parqueadero.domain.services;
using System.Net.Http;
using System.Web.Http;

namespace Parqueadero.infrastructure.restcontroller
{
    [Route("/api/[controller]")]
    [ApiController]
    public class VigilanteController: ControllerBase
    {

        private readonly IVigilanteService _vigilanteService;

        public VigilanteController(IVigilanteService vigilanteService)
        {
            _vigilanteService = vigilanteService;
        }

        [HttpPost("generarTiqueteIngreso")]
        public ActionResult GenerarTiqueteIngreso([FromBody] VehiculoDto vehiculoDto)
        {
            try
            {
                _vigilanteService.GenerarTiquete(vehiculoDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new String(e.Message));
            }
           
        }

        [HttpGet("darSalidaVehiculo")]
        public ActionResult<TiqueteDto> DarSalidaVehiculo([FromBody] VehiculoDto vehiculoDto)
        {

            try
            {
                return _vigilanteService.DarSalidaVehiculo(vehiculoDto);
            }
            catch (Exception e)
            {
                return BadRequest(new String(e.Message));
            }

            
        }
    }
}
