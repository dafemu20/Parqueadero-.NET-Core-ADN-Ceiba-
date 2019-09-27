using Parqueadero.domain.model;
using Parqueadero.domain.services.strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.factory.vehiculo
{
    public interface IValidadorVehiculo
    {
        void ValidarCupo(int cantidadVehiculosEnParqueadero);

        void ValidarPicoPlaca(VehiculoDto vehiculoDto);

        ITiqueteStrategy ResolverInstanciaTarifaStrategy();
    }
}
