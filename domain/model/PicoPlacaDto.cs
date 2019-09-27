using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.model
{
    public class PicoPlacaDto
    {
        public int PicoPlacaId { get; set; }
        public string DescripcionPicoPlaca { get; set; }
        public string DiaPicoPlaca { get; set; }
        public string ValorPlaca { get; set; }
    }
}
