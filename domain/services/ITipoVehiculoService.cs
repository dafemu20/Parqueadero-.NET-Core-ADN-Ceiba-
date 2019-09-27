using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services
{
    public interface ITipoVehiculoService
    {
        List<TipoVehiculoDto> obtenerTodos();

        TipoVehiculoDto obtenerPorId(int id);

        void crearTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);

        void modificarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);

        void eliminarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto);
      
    }
}
