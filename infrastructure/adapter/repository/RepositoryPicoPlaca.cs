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
    public class RepositoryPicoPlaca : IRepositoryPicoPlaca
    {

        private readonly ParqueaderoContext _context;
        private readonly IMapper _mapper;

        public RepositoryPicoPlaca(ParqueaderoContext parqueaderoContext, IMapper mapper)
        {
            _context = parqueaderoContext;
            _mapper = mapper;
        }
        public void crearPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            var picoPlaca = _mapper.Map<PicoPlaca>(picoPlacaDto);
            _context.PicoPlaca.Add(picoPlaca);
            _context.SaveChanges();
        }

        public void eliminarPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            var picoPlaca = _mapper.Map<PicoPlaca>(picoPlacaDto);
            _context.PicoPlaca.Remove(picoPlaca);
            _context.SaveChanges();
        }

        public void modificarPicoPlaca(PicoPlacaDto picoPlacaDto)
        {
            var picoPlaca = _mapper.Map<PicoPlaca>(picoPlacaDto);
            _context.PicoPlaca.Update(picoPlaca);
            _context.SaveChanges();
        }

        public PicoPlacaDto obtenerPorId(int id)
        {
            var picoPlaca = _context.PicoPlaca.Where(p => p.PicoPlacaId == id).FirstOrDefault();
            return _mapper.Map<PicoPlacaDto>(picoPlaca);
        }

        public List<PicoPlacaDto> obtenerTodos()
        {
            var picoPlaca = _context.PicoPlaca.ToList();
            return _mapper.Map<List<PicoPlacaDto>>(picoPlaca);
        }

        public PicoPlacaDto TienePicoPlaca(string diaPicoPlaca, string tipoVehiculo)
        {
            var tienePicoPlaca = _context.PicoPlaca.Where(t => t.DiaPicoPlaca == diaPicoPlaca && t.DescripcionPicoPlaca == tipoVehiculo).FirstOrDefault();
            return _mapper.Map<PicoPlacaDto>(tienePicoPlaca);
        }

    }
}
