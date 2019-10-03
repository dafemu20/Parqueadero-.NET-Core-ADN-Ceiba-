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
    public class RepositoryTiquete : IRepositoryTiquete
    {

        const int SIN_TARIFA = 1;

        private readonly ParqueaderoContext _context;
        private readonly IMapper _mapper;


        public RepositoryTiquete(ParqueaderoContext parqueaderoContext, IMapper mapper)
        {
            _context = parqueaderoContext;
            _mapper = mapper;
        }

        public void crearTiquete(TiqueteDto tiqueteDto)
        {
            var tiquete = _mapper.Map<Tiquete>(tiqueteDto);
            _context.Tiquete.Add(tiquete);
            _context.SaveChanges();
        }

        public void eliminarTiquete(TiqueteDto tiqueteDto)
        {
            var tiquete = _mapper.Map<Tiquete>(tiqueteDto);
            _context.Tiquete.Remove(tiquete);
            _context.SaveChanges();
        }

        public void modificarTiquete(TiqueteDto tiqueteDto)
        {
            var tiquete = _mapper.Map<Tiquete>(tiqueteDto);
            _context.Tiquete.Update(tiquete);
            _context.SaveChanges();
        }

        public TiqueteDto obtenerPorId(int id)
        {
            var tiquete = _context.Tiquete.Where(t => t.TiqueteId == id).FirstOrDefault();
            return _mapper.Map<TiqueteDto>(tiquete);
        }

        public List<TiqueteDto> ObtenerTodos()
        {
            var tiquetes = _context.Tiquete.ToList();
            return _mapper.Map<List<TiqueteDto>>(tiquetes);
        }

        public TiqueteDto ObtenerTiquetePorPlacaVehiculo(string placa)
        {
            var tiquete = _context.Tiquete.Include(t => t.Vehiculo).Where(t => t.Vehiculo.VehiculoPlaca == placa && t.TarifaId == SIN_TARIFA).AsNoTracking().FirstOrDefault();
            return _mapper.Map<TiqueteDto>(tiquete);
        }

        public int obtenerVehiculosEnParqueadero(int idTipoVehiculo)
        {
            return _context.Tiquete.Where(t => t.Vehiculo.TipoVehiculoId == idTipoVehiculo && t.TarifaId ==SIN_TARIFA).Count();
        }

    }
}
