using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Parqueadero.domain.model;
using Parqueadero.data;
using Parqueadero.domain.services;
using Parqueadero.domain.services.implementacion;

namespace Parqueadero.configuration
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<TipoVehiculo, TipoVehiculoDto>();
            CreateMap<TipoVehiculoDto, TipoVehiculo>();

            CreateMap<Vehiculo, VehiculoDto>();
            CreateMap<VehiculoDto, Vehiculo>();

            CreateMap<PicoPlaca, PicoPlacaDto>();
            CreateMap<PicoPlacaDto, PicoPlaca>();

            CreateMap<Tarifa, TarifaDto>();
            CreateMap<TarifaDto, Tarifa>();

            CreateMap<Tiquete, TiqueteDto>();
            CreateMap<TiqueteDto, Tiquete>();

        }
    }
}
