using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.port;
using Parqueadero.domain.model;

namespace Parqueadero.domain.services.implementacion
{
    public class PicoPlacaService : IPicoPlacaService
    {
        private readonly IRepositoryPicoPlaca _repositoryPicoPlaca;

        public PicoPlacaService(IRepositoryPicoPlaca repositoryPicoPlaca)
        {
            _repositoryPicoPlaca = repositoryPicoPlaca;
        }

        public List<PicoPlacaDto> obtenerTodos()
        {
            return _repositoryPicoPlaca.obtenerTodos();
        }

        public PicoPlacaDto obtenerPorId(int id)
        {
            return _repositoryPicoPlaca.obtenerPorId(id);
        }

        public void crearPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            _repositoryPicoPlaca.crearPicoPlaca(picoPlacaDto);
        }

        public void modificarPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            _repositoryPicoPlaca.modificarPicoPlaca(picoPlacaDto);
        }

        public void eliminarPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            _repositoryPicoPlaca.eliminarPicoPlaca(picoPlacaDto);
        }

        public PicoPlacaDto TienePicoPlaca(string diaPicoPlaca, string tipoVehiculo)
        {
            return _repositoryPicoPlaca.TienePicoPlaca(diaPicoPlaca, tipoVehiculo);
        }
    }
}
