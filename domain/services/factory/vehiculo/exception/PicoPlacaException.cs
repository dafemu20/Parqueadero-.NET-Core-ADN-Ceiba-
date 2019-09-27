using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.factory.vehiculo.exception
{
    public class PicoPlacaException : Exception
    {
        public PicoPlacaException(string mensaje) : base(mensaje) { }
    }
}
