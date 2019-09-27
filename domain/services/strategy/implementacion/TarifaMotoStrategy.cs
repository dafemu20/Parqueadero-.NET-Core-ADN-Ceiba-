using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;

namespace Parqueadero.domain.services.strategy.implementacion
{
    public class TiqueteMotoStrategy : ITiqueteStrategy
    {

        public TiqueteDto CalcularValorTiquete(TiqueteDto tiqueteDto)
        {

            decimal valorTotal = ObtenerValorTotal(tiqueteDto);

            return new TiqueteDto { FechaFin = DateTime.Now,
                                    TarifaId = 2,
                                    ValorTotal = valorTotal,
                                  };
        }

        private decimal ObtenerValorTotal(TiqueteDto tiqueteDto)
        {
            decimal valorTotal;

            var totalHorasVehiculoEnParqueadero = (int)(Math.Ceiling((DateTime.Now - tiqueteDto.FechaInicio).TotalHours));

            if (totalHorasVehiculoEnParqueadero < 9)
            {
                valorTotal = totalHorasVehiculoEnParqueadero * 500;
            }
            else
            {
                decimal valorRestante = totalHorasVehiculoEnParqueadero % 24;
                decimal valorTotalDias = (totalHorasVehiculoEnParqueadero - valorRestante) / 24;

                valorTotal = valorTotalDias * 4000;

                if (valorRestante > 9)
                {
                    valorTotal += 4000;
                }
                else
                {
                    valorTotal += (valorRestante * 500);
                }
            }

            valorTotal += tiqueteDto.Vehiculo.Cilindraje > 500 ? 2000 : 0;

            return valorTotal;
        }
    }
}
