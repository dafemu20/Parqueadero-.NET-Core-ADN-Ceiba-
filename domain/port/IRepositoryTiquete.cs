using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;

namespace Parqueadero.domain.port
{
    public interface IRepositoryTiquete
    {
        List<TiqueteDto> ObtenerTodos();

        TiqueteDto obtenerPorId(int id);

        void crearTiquete(TiqueteDto tiqueteDto);

        void modificarTiquete(TiqueteDto tiqueteDto);

        void eliminarTiquete(TiqueteDto tiqueteDto);

        int obtenerVehiculosEnParqueadero(int idTipoVehiculo);

        TiqueteDto ObtenerTiquetePorPlacaVehiculo(string placa);
    }
}
