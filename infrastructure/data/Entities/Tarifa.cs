using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.data
{
    public class Tarifa
    {

        public int TarifaId { get; set; }
        public string DescripcionTarifa { get; set; }
        public decimal ValorTarifa { get; set; }
        public ICollection<Tiquete>  Tiquetes { get; set; }
    }
}
