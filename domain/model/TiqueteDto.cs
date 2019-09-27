using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.model
{
    public class TiqueteDto
    {

        public int TiqueteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal ValorTotal { get; set; }
        public int TarifaId { get; set; }
        public int VehiculoId { get; set; }
        public VehiculoDto Vehiculo { get; set; }
    }
}
