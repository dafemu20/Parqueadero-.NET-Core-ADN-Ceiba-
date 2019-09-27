using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.strategy
{
    public interface ITiqueteStrategy
    {
        TiqueteDto CalcularValorTiquete(TiqueteDto tiqueteDto);

    }
}
