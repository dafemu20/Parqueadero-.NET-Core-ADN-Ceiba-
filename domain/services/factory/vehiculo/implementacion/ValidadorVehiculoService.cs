using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;
using Parqueadero.domain.services;
using Parqueadero.domain.services.factory.vehiculo.exception;
using Parqueadero.domain.services.strategy;

namespace Parqueadero.domain.services.factory.vehiculo.implementacion
{
    public class ValidadorVehiculoService
    {

        const string VEHIVULO_EN_PICO_PLACA = "El vehiculo tiene pico y placa el día de hoy, por lo tanto no puede ingresar al parqueadero. Disculpe las molestias";
        const string NO_HAY_CUPO_DISPONIBLE = "No tenemos cupo disponible";

        private readonly IPicoPlacaService _picoPlacaService;

        public ValidadorVehiculoService(IPicoPlacaService picoPlacaService)
        {
            _picoPlacaService = picoPlacaService;
        }

        public void ValidarCupo(int limiteCupo, int cantidadVehiculosEnParqueadero)
        {
            if (limiteCupo <= cantidadVehiculosEnParqueadero)
            {
                throw new CupoException(NO_HAY_CUPO_DISPONIBLE);
            }
        }

        public void ValidarPicoPlaca(string tipoVehiculo, string placa)
        {
            PicoPlacaDto picoPlacaDto = _picoPlacaService.TienePicoPlaca(HomologarDiaEspanol(DateTime.Now.DayOfWeek.ToString()), tipoVehiculo);
            string[] valoresPicoPlaca = picoPlacaDto.ValorPlaca.Split(",");
            bool tienePicoPlaca = Array.Exists(valoresPicoPlaca, elemento => elemento == placa.Substring(5, 1));
            if (tienePicoPlaca)
            {
                throw new PicoPlacaException(VEHIVULO_EN_PICO_PLACA);
            }
        }

        private string HomologarDiaEspanol(string diaIngles)
        {
            Dictionary<string, string> diccionarioDias = new Dictionary<string, string>
            {
                { "Monday", "Lunes" },
                { "Tuesday", "Martes" },
                { "Wednesday", "Miercoles" },
                { "Thursday", "Jueves" },
                { "Friday", "Viernes" }
            };

            return diccionarioDias[diaIngles];
        }



        

    }
}
