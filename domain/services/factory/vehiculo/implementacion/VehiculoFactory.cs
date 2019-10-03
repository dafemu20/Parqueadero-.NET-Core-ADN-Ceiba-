using Parqueadero.domain.services.implementacion;
using Parqueadero.domain.services.factory.vehiculo.exception;
using Parqueadero.domain.port;

namespace Parqueadero.domain.services.factory.vehiculo.implementacion
{
    public class VehiculoFactory : IVehiculoFactory
    {
        const string VEHICULO_NO_SOPORTADO = "El tipo de vehiculo ingresado no es soportado en el parqueadero";

        const int MOTO = 1;
        const int CARRO = 2;

        private readonly IPicoPlacaService _picoPlacaService;

        public VehiculoFactory(IPicoPlacaService picoPlacaService)
        {
            _picoPlacaService = picoPlacaService;
        }

        public IValidadorVehiculo CrearVehiculo(int idTipoVehiculo)
        {
            if (MOTO == idTipoVehiculo)
            {
                return new ValidadorMotoService(_picoPlacaService);
            }
            else if (CARRO == idTipoVehiculo)
            {
                return new ValidadorCarroService(_picoPlacaService);
            }

            throw new TipoVehiculoException(VEHICULO_NO_SOPORTADO);
        }
    }
}
