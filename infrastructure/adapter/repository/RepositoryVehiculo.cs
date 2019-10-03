using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;
using Parqueadero.domain.port;
using Parqueadero.data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Parqueadero.infrastructure.adapter.repository
{
    public class RepositoryVehiculo : IRepositoryVehiculo
    {

        private readonly ParqueaderoContext _context;
        private readonly IMapper _mapper;

        public RepositoryVehiculo(ParqueaderoContext parqueaderoContext, IMapper mapper)
        {
            _context = parqueaderoContext;
            _mapper = mapper;
        }

        public void crearVehiculo(VehiculoDto vehiculoDto)
        {
            var vehiculo = _mapper.Map<Vehiculo>(vehiculoDto);
            _context.Vehiculo.Add(vehiculo);
            _context.SaveChanges();
        }

        public void eliminarVehiculo(VehiculoDto vehiculoDto)
        {
            var vehiculo = _mapper.Map<Vehiculo>(vehiculoDto);
            _context.Vehiculo.Remove(vehiculo);
            _context.SaveChanges();
        }

        public void modificarVehiculo(VehiculoDto vehiculoDto)
        {
            var vehiculo = _mapper.Map<Vehiculo>(vehiculoDto);
            _context.Vehiculo.Update(vehiculo);
            _context.SaveChanges();
        }

        public VehiculoDto obtenerPorPlaca(string placa)
        {
            var vehiculo = _context.Vehiculo.Where(v => v.VehiculoPlaca == placa).FirstOrDefault();
            return _mapper.Map<VehiculoDto>(vehiculo);
        }

        public List<VehiculoDto> obtenerTodos()
        {
            var vehiculos = _context.Vehiculo.ToList();
            return _mapper.Map<List<VehiculoDto>>(vehiculos);
        }

    }
}
