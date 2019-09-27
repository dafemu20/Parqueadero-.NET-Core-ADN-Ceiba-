using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Parqueadero.data
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string VehiculoPlaca { get; set; }
        public string DescripcionVehiculo { get; set; }

        public int Cilindraje { get; set; }

        public int TipoVehiculoId { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }

        public ICollection<Tiquete> Tiquetes { get; set; }


    }
}
