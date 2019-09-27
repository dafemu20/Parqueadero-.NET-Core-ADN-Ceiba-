using Parqueadero.domain.model;
using Parqueadero.domain.services.factory.vehiculo.implementacion;
using Parqueadero.domain.services.strategy;
using Parqueadero.domain.services.strategy.implementacion;

namespace Parqueadero.domain.services.factory.vehiculo
{
    public class ValidadorCarroService : ValidadorVehiculoService, IValidadorVehiculo
    {

        const int LIMITE_CUPOS_CARROS = 20;
        const string CARRO = "Carro";

        public ValidadorCarroService(IPicoPlacaService picoPlacaService):base(picoPlacaService){}

        public void ValidarCupo(int cantidadVehiculosEnParqueadero)
        {
            base.ValidarCupo(LIMITE_CUPOS_CARROS, cantidadVehiculosEnParqueadero);
        }

        public void ValidarPicoPlaca(VehiculoDto vehiculoDto)
        {
            base.ValidarPicoPlaca(CARRO, vehiculoDto.VehiculoPlaca);
        }

        public ITiqueteStrategy ResolverInstanciaTarifaStrategy()
        {
            return new TiqueteCarroStrategy();
        }
    }
}
