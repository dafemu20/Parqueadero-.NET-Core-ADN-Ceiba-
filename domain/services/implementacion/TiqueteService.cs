using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.port;
using Parqueadero.domain.model;

namespace Parqueadero.domain.services.implementacion
{
    public class TiqueteService : ITiqueteService
    {
        private readonly IRepositoryTiquete _repositoryTiquete;

        public TiqueteService(IRepositoryTiquete repositoryTiquete)
        {
            _repositoryTiquete= repositoryTiquete;
        }

        public List<TiqueteDto> obtenerTodos()
        {
            return _repositoryTiquete.ObtenerTodos();
        }

        public TiqueteDto obtenerPorId(int id)
        {
            return _repositoryTiquete.obtenerPorId(id);
        }

        public void crearTiquete(TiqueteDto tiqueteDto)
        {
            _repositoryTiquete.crearTiquete(tiqueteDto);
        }

        public void modificarTiquete(TiqueteDto tiqueteDto)
        {
            _repositoryTiquete.modificarTiquete(tiqueteDto);
        }

        public void eliminarTiquete(TiqueteDto tiqueteDto)
        {
            _repositoryTiquete.eliminarTiquete(tiqueteDto);
        }

        public int obtenerVehiculosEnParqueadero(int idTipoVehiculo)
        {
            return _repositoryTiquete.obtenerVehiculosEnParqueadero(idTipoVehiculo);
        }

        public TiqueteDto ObtenerTiquetePorPlacaVehiculo(string placa)
        {
            return _repositoryTiquete.ObtenerTiquetePorPlacaVehiculo(placa);
        }

    }
}
