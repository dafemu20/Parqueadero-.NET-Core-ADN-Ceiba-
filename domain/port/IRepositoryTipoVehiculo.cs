using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;

namespace Parqueadero.domain.port
{
    public interface IRepositoryTipoVehiculo
    {
        List<TipoVehiculoDto> obtenerTodos();

        TipoVehiculoDto obtenerPorId(int id);

        void crearTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);

        void modificarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);

        void eliminarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);

    }
}
