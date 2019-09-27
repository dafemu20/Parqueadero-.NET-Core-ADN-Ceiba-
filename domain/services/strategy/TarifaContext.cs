using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services.strategy
{
    public class TiqueteContext
    {
        private ITiqueteStrategy _tiqueteStrategy;

        public void SetTarifaStrategy(ITiqueteStrategy tiqueteStrategy)
        {
            _tiqueteStrategy = tiqueteStrategy;
        }

        public TiqueteDto CalcularValorTiquete(TiqueteDto tiqueteDto)
        {
            return _tiqueteStrategy.CalcularValorTiquete(tiqueteDto);
        }
    }
}
