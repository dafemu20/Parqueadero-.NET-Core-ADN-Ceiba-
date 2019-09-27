using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.port
{
    public interface IRepositoryPicoPlaca
    {
        List<PicoPlacaDto> obtenerTodos();

        PicoPlacaDto obtenerPorId(int id);

        void crearPicoPlaca(PicoPlacaDto picoPlacaDto);

        void modificarPicoPlaca(PicoPlacaDto picoPlacaDto);

        void eliminarPicoPlaca(PicoPlacaDto picoPlacaDto);

        PicoPlacaDto TienePicoPlaca(string diaPicoPlaca, string tipoVehiculo);
    }
}
