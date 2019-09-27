using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.model
{
    public class TarifaDto
    {
        public int TarifaId { get; set; }
        public string DescripcionTarifa { get; set; }
        public decimal ValorTarifa { get; set; }
    }
}
