using Parqueadero.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.domain.services
{
    public interface ITiqueteService
    {

        List<TiqueteDto> obtenerTodos();

        TiqueteDto obtenerPorId(int id);

        void crearTiquete(TiqueteDto tiqueteDto);

        void modificarTiquete(TiqueteDto tiqueteDto);

        void eliminarTiquete(TiqueteDto tiqueteDto);

        int obtenerVehiculosEnParqueadero(int idTipoVehiculo);

        TiqueteDto ObtenerTiquetePorPlacaVehiculo(string placa);



    }
}
