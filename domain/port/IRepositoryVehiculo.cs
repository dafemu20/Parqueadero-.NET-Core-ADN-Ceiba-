using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;

namespace Parqueadero.domain.port
{
    public interface IRepositoryVehiculo
    {
        List<VehiculoDto> obtenerTodos();

        VehiculoDto obtenerPorPlaca(string placa);

        void crearVehiculo(VehiculoDto vehiculoDto);

        void modificarVehiculo(VehiculoDto vehiculoDto);

        void eliminarVehiculo(VehiculoDto vehiculoDto);


    }
}
