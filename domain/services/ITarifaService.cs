using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services
{
    public interface ITarifaService
    {
        List<TarifaDto> obtenerTodos();

        TarifaDto obtenerPorId(int id);

        void crearTarifa(TarifaDto tipoVehiculoDto);

        void modificarTarifa(TarifaDto tipoVehiculoDto);

        void eliminarTarifa(TarifaDto tipoVehiculoDto);
     
    }
}
