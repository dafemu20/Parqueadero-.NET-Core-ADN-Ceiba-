using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;
using Parqueadero.domain.port;
using Parqueadero.domain.services;
using Parqueadero.domain.services.factory.vehiculo;
using Parqueadero.domain.services.factory.vehiculo.implementacion;
using Parqueadero.domain.services.excepciones;
using Parqueadero.domain.services.strategy;

namespace Parqueadero.domain.services.implementacion
{
    public class VigilanteService : IVigilanteService
    {

        const int SIN_TARIFA = 1;

        private readonly ITiqueteService _tiqueteService;
        private readonly IVehiculoService _vehiculoService;
        private readonly IPicoPlacaService _picoPlacaService;
        private IValidadorVehiculo validadorVehiculoService;

        public VigilanteService(ITiqueteService tiqueteService, IVehiculoService vehiculoService, IPicoPlacaService picoPlacaService)
        {
            _tiqueteService = tiqueteService;
            _vehiculoService = vehiculoService;
            _picoPlacaService = picoPlacaService;
        }

        public void GenerarTiquete(VehiculoDto vehiculoDto)
        {
            ValidarIngreso(vehiculoDto);
            IngresarVehiculo(vehiculoDto);
        }

        public TiqueteDto DarSalidaVehiculo(VehiculoDto vehiculoDto)
        {
            TiqueteDto tiqueteEntrada = ObtenerTiqueteEntrada(vehiculoDto);
            return ObtenerTiqueteSalida(tiqueteEntrada);
        }

        private void ValidarIngreso(VehiculoDto vehiculoDto)
        {
            validadorVehiculoService = CrearVehiculoService(vehiculoDto, _picoPlacaService);
            validadorVehiculoService.ValidarCupo(ObtenerCantidadVehiculosEnParqueadero(vehiculoDto));
            validadorVehiculoService.ValidarPicoPlaca(vehiculoDto);
        }

        private IValidadorVehiculo CrearVehiculoService(VehiculoDto vehiculoDto, IPicoPlacaService picoPlacaService)
        {
            IVehiculoFactory vehiculoFactory = new VehiculoFactory(picoPlacaService);
            return vehiculoFactory.CrearVehiculo(vehiculoDto.TipoVehiculoId);
        }

        private void IngresarVehiculo(VehiculoDto vehiculoDto)
        {
            try
            {
                _vehiculoService.crearVehiculo(vehiculoDto);
                RegistrarTiquete(vehiculoDto);
            }
            catch (VehiculoException)
            {
                RegistrarTiquete(vehiculoDto);
            }
        }

        private void RegistrarTiquete(VehiculoDto vehiculoDto)
        {
            VehiculoDto vehiculo = _vehiculoService.obtenerPorPlaca(vehiculoDto.VehiculoPlaca);
            TiqueteDto tiqueteDto = new TiqueteDto {FechaFin=DateTime.Now,
                                                    FechaInicio = DateTime.Now,
                                                    TarifaId = SIN_TARIFA,
                                                    ValorTotal=0,
                                                    VehiculoId = vehiculo.VehiculoId};
            _tiqueteService.crearTiquete(tiqueteDto);
        }

        private TiqueteDto ObtenerTiqueteEntrada(VehiculoDto vehiculoDto)
        {
            return _tiqueteService.ObtenerTiquetePorPlacaVehiculo(vehiculoDto.VehiculoPlaca);
        }

        private TiqueteDto ObtenerTiqueteSalida(TiqueteDto tiqueteDto)
        {
            TiqueteContext tiqueteContext = new TiqueteContext();
            tiqueteContext.SetTarifaStrategy(validadorVehiculoService.ResolverInstanciaTarifaStrategy());
            return tiqueteContext.CalcularValorTiquete(tiqueteDto);

        }

        private int ObtenerCantidadVehiculosEnParqueadero(VehiculoDto vehiculoDto)
        {
            return _tiqueteService.obtenerVehiculosEnParqueadero(vehiculoDto.TipoVehiculoId);
        }

        
    }
}
