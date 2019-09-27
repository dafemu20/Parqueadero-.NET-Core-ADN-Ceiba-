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
    [Route("/api/[controller]")]
    [ApiController]
    public class PicoPlacaController: ControllerBase
    {
        private readonly IPicoPlacaService picoPlacaService;

        public PicoPlacaController(IPicoPlacaService picoPlacaService)
        {
            this.picoPlacaService = picoPlacaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PicoPlacaDto>> obtenerTodos()
        {
            return picoPlacaService.obtenerTodos();
        }

        [HttpGet("{id}")]
        public ActionResult<PicoPlacaDto> obtenerPorId(int id)
        {
            return picoPlacaService.obtenerPorId(id);
        }

        [HttpPost]
        public void crearPicoPlaca([FromBody] PicoPlacaDto picoPlacaDto)
        {
            picoPlacaService.crearPicoPlaca(picoPlacaDto);
        }

        [HttpPut]
        public void modificarPicoPlaca([FromBody] PicoPlacaDto picoPlacaDto)
        {
            picoPlacaService.modificarPicoPlaca(picoPlacaDto);
        }

        [HttpDelete]
        public void eliminarPicoPlaca([FromBody] PicoPlacaDto picoPlacaDto)
        {
            picoPlacaService.eliminarPicoPlaca(picoPlacaDto);
        }
    }
}
