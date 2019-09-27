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
    public class TarifaController: ControllerBase
    {
        private readonly TarifaService tarifaService;

        public TarifaController(TarifaService tarifaService)
        {
            this.tarifaService = tarifaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TarifaDto>> obtenerTodos()
        {
            return tarifaService.obtenerTodos();
        }

        [HttpGet("{id}")]
        public ActionResult<TarifaDto> obtenerPorId(int id)
        {
            return tarifaService.obtenerPorId(id);
        }

        [HttpPost]
        public void crearTarifa([FromBody] TarifaDto tarifaDto)
        {
            tarifaService.crearTarifa(tarifaDto);
        }

        [HttpPut]
        public void modificarTarifa([FromBody] TarifaDto tarifaDto)
        {
            tarifaService.modificarTarifa(tarifaDto);
        }

        [HttpDelete]
        public void eliminarTarifa([FromBody] TarifaDto tarifaDto)
        {
            tarifaService.eliminarTarifa(tarifaDto);
        }
    }
}
