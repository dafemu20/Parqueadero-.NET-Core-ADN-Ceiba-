using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.model;
using Parqueadero.domain.port;
using Parqueadero.data;
using AutoMapper;

namespace Parqueadero.infrastructure.adapter.repository
{
    public class RepositoryTipoVehiculo : IRepositoryTipoVehiculo
    {
        private readonly ParqueaderoContext _context;
        private readonly IMapper _mapper;

        public RepositoryTipoVehiculo(ParqueaderoContext parqueaderoContext, IMapper mapper)
        {
            _context = parqueaderoContext;
            _mapper = mapper;
        }

        public void crearTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            var tipoVehiculo = _mapper.Map<TipoVehiculo>(tipoVehiculoDto);
            _context.TipoVehiculo.Add(tipoVehiculo);
            _context.SaveChanges();
        }

        public void eliminarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            var tipoVehiculo = _mapper.Map<TipoVehiculo>(tipoVehiculoDto);
            _context.TipoVehiculo.Remove(tipoVehiculo);
            _context.SaveChanges();
        }

        public void modificarTipoVehiculo(TipoVehiculoDto tipoVehiculoDto)
        {
            var tipoVehiculo = _mapper.Map<TipoVehiculo>(tipoVehiculoDto);
            _context.TipoVehiculo.Update(tipoVehiculo);
            _context.SaveChanges();
        }

        public TipoVehiculoDto obtenerPorId(int id)
        {
            var tipoVehiculo = _context.TipoVehiculo.Where(t => t.TipoVehiculoId == id).FirstOrDefault();
            return _mapper.Map<TipoVehiculoDto>(tipoVehiculo);
        }

        public List<TipoVehiculoDto> obtenerTodos()
        {
            var tiposVehiculos = _context.TipoVehiculo.ToList();
            return _mapper.Map<List<TipoVehiculoDto>>(tiposVehiculos);
        }
    }
}
