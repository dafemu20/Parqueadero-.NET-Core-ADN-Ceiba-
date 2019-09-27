using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;

namespace Parqueadero.domain.port
{
    public interface IRepositoryTarifa
    {
        List<TarifaDto> obtenerTodos();

        TarifaDto obtenerPorId(int id);

        void crearTarifa(TarifaDto tarifaDto);

        void modificarTarifa(TarifaDto tarifaDto);

        void eliminarTarifa(TarifaDto tarifaDto);
    }
}
