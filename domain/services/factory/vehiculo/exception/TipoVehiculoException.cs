using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.factory.vehiculo.exception
{
    public class TipoVehiculoException : Exception
    {
        public TipoVehiculoException(string mensaje) : base(mensaje) { }
    }
}
