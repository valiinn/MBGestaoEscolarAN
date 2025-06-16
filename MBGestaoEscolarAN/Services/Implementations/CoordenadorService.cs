using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CoordenadorService:ICoordenadorService
    {
        private readonly SQLServerDbContext _contexto;

        public CoordenadorService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Coordenador coordenador)
        {
            _contexto.Coordenadores.Add(coordenador);
            await _contexto.SaveChangesAsync();
            return coordenador.CoordenadorId;
        }

        public async Task<bool> AlterarAsync(Coordenador coordenador)
        {
            var coordenadorExiste = await _contexto.Coordenadores.FindAsync(coordenador.CoordenadorId);
            if (coordenadorExiste == null)
            {
                return false;
            }
            _contexto.Entry(coordenadorExiste).CurrentValues.SetValues(coordenador);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var coordenador = await _contexto.Coordenadores.FindAsync(id);
            if (coordenador == null)
            {
                return false;
            }
            _contexto.Coordenadores.Remove(coordenador);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Coordenador?> ListarPorIdAsync(int id)
        {
            return await _contexto.Coordenadores
                           .AsNoTracking()
                           .FirstOrDefaultAsync(x => x.CoordenadorId == id);
        }

        public async Task<IEnumerable<Coordenador>> ListarTodosAsync()
        {
            return await _contexto.Coordenadores
                           .AsNoTracking()
                           .OrderBy(x => x.Nome)
                           .ToListAsync();
        }
    }
}
