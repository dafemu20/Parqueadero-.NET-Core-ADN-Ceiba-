using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.model
{
    public class VehiculoDto
    {
        public string VehiculoPlaca { get; set; }
        public string DescripcionVehiculo { get; set; }
        public int Cilindraje { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}
