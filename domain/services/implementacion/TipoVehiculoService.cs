using Parqueadero.domain.model;
using Parqueadero.domain.port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.implementacion
{
    public class TipoVehiculoService : ITipoVehiculoService
    {
        private readonly IRepositoryTipoVehiculo _repositoryTipoVehiculo;

        public TipoVehiculoService(IRepositoryTipoVehiculo repositoryTipoVehiculo)
        {
            _repositoryTipoVehiculo = repositoryTipoVehiculo;
        }

        public List<TipoVehiculoDto> obtenerTodos()
        {
            return _repositoryTipoVehiculo.obtenerTodos();
        }

        public TipoVehiculoDto obtenerPorId(int id)
        {
            return _repositoryTipoVehiculo.obtenerPorId(id);
        }

        public void crearTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            _repositoryTipoVehiculo.crearTipoVehiculo(tipoVehiculoDto);
        }

        public void modificarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            _repositoryTipoVehiculo.modificarTipoVehiculo(tipoVehiculoDto);
        }

        public void eliminarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            _repositoryTipoVehiculo.eliminarTipoVehiculo(tipoVehiculoDto);
        }
    }
}
