using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parqueadero.domain.port;
using Parqueadero.domain.model;
using Parqueadero.data;
using AutoMapper;

namespace Parqueadero.infrastructure.adapter.repository
{
    public class RepositoryTarifa : IRepositoryTarifa
    {

        private readonly ParqueaderoContext _context;
        private readonly IMapper _mapper;

        public RepositoryTarifa(ParqueaderoContext parqueaderoContext, IMapper mapper)
        {
            _context = parqueaderoContext;
            _mapper = mapper;
        }

        public void crearTarifa(TarifaDto tarifaDto)
        {
            var tarifa = _mapper.Map<Tarifa>(tarifaDto);
            _context.Tarifa.Add(tarifa);
            _context.SaveChanges();
        }

        public void eliminarTarifa(TarifaDto tarifaDto)
        {
            var tarifa = _mapper.Map<Tarifa>(tarifaDto);
            _context.Tarifa.Remove(tarifa);
            _context.SaveChanges();
        }

        public void modificarTarifa(TarifaDto tarifaDto)
        {
            var tarifa = _mapper.Map<Tarifa>(tarifaDto);
            _context.Tarifa.Update(tarifa);
            _context.SaveChanges();
        }

        public TarifaDto obtenerPorId(int id)
        {
            var tarifa = _context.Tarifa.Where(t => t.TarifaId == id).FirstOrDefault();
            return _mapper.Map<TarifaDto>(tarifa);
        }

        public List<TarifaDto> obtenerTodos()
        {
            var tarifa = _context.Tarifa.ToList();
            return _mapper.Map<List<TarifaDto>>(tarifa);
        }
    }
}
