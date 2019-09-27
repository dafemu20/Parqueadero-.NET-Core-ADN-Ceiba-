using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parqueadero.domain.model;
using Parqueadero.domain.services;

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
        public void GenerarTiqueteIngreso([FromBody] VehiculoDto vehiculoDto)
        {
            _vigilanteService.GenerarTiquete(vehiculoDto);
        }

        [HttpGet("darSalidaVehiculo")]
        public TiqueteDto DarSalidaVehiculo([FromBody] VehiculoDto vehiculoDto)
        {
            return _vigilanteService.DarSalidaVehiculo(vehiculoDto);
        }
    }
}
