using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.excepciones
{
    public class VehiculoException:Exception
    {
        public VehiculoException(string mensaje) : base(mensaje) { }
    }
}
