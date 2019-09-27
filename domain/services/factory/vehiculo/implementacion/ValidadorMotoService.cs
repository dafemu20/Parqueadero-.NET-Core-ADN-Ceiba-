using Parqueadero.domain.model;
using Parqueadero.domain.services.factory.vehiculo.implementacion;
using Parqueadero.domain.services.strategy;
using Parqueadero.domain.services.strategy.implementacion;

namespace Parqueadero.domain.services.factory.vehiculo
{
    public class ValidadorMotoService : ValidadorVehiculoService, IValidadorVehiculo
    {


        const int LIMITE_CUPOS_MOTOS = 10;
        const string MOTO = "Moto";


        public ValidadorMotoService(IPicoPlacaService picoPlacaService):base(picoPlacaService){ }

        public void ValidarCupo(int cantidadVehiculosEnParqueadero)
        {
            base.ValidarCupo(LIMITE_CUPOS_MOTOS, cantidadVehiculosEnParqueadero);
            
        }

        public void ValidarPicoPlaca(VehiculoDto vehiculoDto)
        {
            base.ValidarPicoPlaca(MOTO, vehiculoDto.VehiculoPlaca);
        }

        public ITiqueteStrategy ResolverInstanciaTarifaStrategy()
        {
            return new TiqueteMotoStrategy();
        }



    }
}
