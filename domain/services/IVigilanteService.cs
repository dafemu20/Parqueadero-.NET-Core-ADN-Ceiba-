using Parqueadero.domain.model;

namespace Parqueadero.domain.services
{
    public interface IVigilanteService
    {
        void GenerarTiquete(VehiculoDto vehiculoDto);

        TiqueteDto DarSalidaVehiculo(VehiculoDto vehiculoDto);


    }
}
