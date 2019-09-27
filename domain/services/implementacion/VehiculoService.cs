using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.port;
using Parqueadero.domain.model;
using Parqueadero.domain.services.excepciones;
namespace Parqueadero.domain.services.implementacion
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IRepositoryVehiculo _repositoryVehiculo;

        public VehiculoService(IRepositoryVehiculo repositoryVehiculo)
        {
            _repositoryVehiculo = repositoryVehiculo;
        }

        public List<VehiculoDto> obtenerTodos()
        {
            return _repositoryVehiculo.obtenerTodos();
        }

        public VehiculoDto obtenerPorId(int id)
        {
            return _repositoryVehiculo.obtenerPorId(id);
        }

        public void crearVehiculo(VehiculoDto VehiculoDto)
        {
            if (_repositoryVehiculo.obtenerPorPlaca(VehiculoDto.VehiculoPlaca) != null)
            {
                throw new VehiculoException("Vehiculo ya esta registrado");
            }
            _repositoryVehiculo.crearVehiculo(VehiculoDto);
        }

        public void modificarVehiculo(VehiculoDto VehiculoDto)
        {
            _repositoryVehiculo.modificarVehiculo(VehiculoDto);
        }


        public void eliminarVehiculo(VehiculoDto VehiculoDto)
        {
            _repositoryVehiculo.eliminarVehiculo(VehiculoDto);
        }

        public VehiculoDto obtenerPorPlaca(string placa)
        {
            return _repositoryVehiculo.obtenerPorPlaca(placa);
        }
    }
}
