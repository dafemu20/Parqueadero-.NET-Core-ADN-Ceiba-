using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.port;
using Parqueadero.domain.model;

namespace Parqueadero.domain.services.implementacion
{
    public class TarifaService : ITarifaService
    {
        private readonly IRepositoryTarifa _repositoryTarifa;
        public TarifaService(IRepositoryTarifa repositoryTarifa)
        {
            _repositoryTarifa = repositoryTarifa;
        }

        public List<TarifaDto> obtenerTodos()
        {
            return _repositoryTarifa.obtenerTodos();
        }

        public TarifaDto obtenerPorId(int id)
        {
            return _repositoryTarifa.obtenerPorId(id);
        }

        public void crearTarifa(TarifaDto tipoVehiculoDto)
        {
            _repositoryTarifa.crearTarifa(tipoVehiculoDto);
        }

        public void modificarTarifa(TarifaDto tipoVehiculoDto)
        {
            _repositoryTarifa.modificarTarifa(tipoVehiculoDto);
        }

        public void eliminarTarifa(TarifaDto tipoVehiculoDto)
        {
            _repositoryTarifa.eliminarTarifa(tipoVehiculoDto);
        }
    }
}
