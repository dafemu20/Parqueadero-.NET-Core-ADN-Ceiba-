using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Parqueadero.data
{
    public class Tiquete
    {
        public int TiqueteId { get; set; }
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
        public decimal ValorTotal { get; set; }

        public int TarifaId { get; set; }
        public Tarifa Tarifa { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
