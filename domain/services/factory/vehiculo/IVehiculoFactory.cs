using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.services.implementacion;

namespace Parqueadero.domain.services.factory.vehiculo
{
    interface IVehiculoFactory
    {
        IValidadorVehiculo CrearVehiculo(int idTipoVehiculo);
    }
}
