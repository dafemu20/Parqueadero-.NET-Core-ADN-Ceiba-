using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.data
{
    public class TipoVehiculo
    {
        public int TipoVehiculoId { get; set; }

        public string DescripcionTipoVehiculo { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
