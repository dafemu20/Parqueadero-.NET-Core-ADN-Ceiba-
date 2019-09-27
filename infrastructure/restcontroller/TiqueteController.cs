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
    public class TiqueteController: ControllerBase
    {
        private readonly TiqueteService tiqueteService;

        public TiqueteController(TiqueteService tiqueteService)
        {
            this.tiqueteService = tiqueteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TiqueteDto>> obtenerTodos()
        {
            return tiqueteService.obtenerTodos();
        }

        [HttpGet("{id}")]
        public ActionResult<TiqueteDto> obtenerPorId(int id)
        {
            return tiqueteService.obtenerPorId(id);
        }

        [HttpPost]
        public void crearTiquete([FromBody] TiqueteDto tiqueteDto)
        {
            tiqueteService.crearTiquete(tiqueteDto);
        }

        [HttpPut]
        public void modificarTiquete([FromBody] TiqueteDto tiqueteDto)
        {
            tiqueteService.modificarTiquete(tiqueteDto);
        }

        [HttpDelete]
        public void eliminarTiquete([FromBody] TiqueteDto tiqueteDto)
        {
            tiqueteService.eliminarTiquete(tiqueteDto);
        }
    }
}
