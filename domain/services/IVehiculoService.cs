using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services
{
    public interface IVehiculoService
    {
        List<VehiculoDto> obtenerTodos();

        void crearVehiculo(VehiculoDto VehiculoDto);

        void modificarVehiculo(VehiculoDto VehiculoDto);

        void eliminarVehiculo(VehiculoDto VehiculoDto);

        VehiculoDto obtenerPorPlaca(string placa);


    }
}
