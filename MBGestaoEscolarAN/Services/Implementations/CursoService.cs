using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CursoService:ICursoService
    {
        private readonly SQLServerDbContext _contexto;

        public CursoService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Curso curso)
        {
            _contexto.Cursos.Add(curso);
            await _contexto.SaveChangesAsync();
            return curso.CursoId;

        }

        public async Task<bool> AlterarAsync(Curso curso)
        {
            var cursoExiste = await _contexto.Cursos.FindAsync(curso.CursoId);
            if (cursoExiste == null)
            {
                return false;
            }
            _contexto.Entry(cursoExiste).CurrentValues.SetValues(curso);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var curso = await _contexto.Cursos.FindAsync(id);
            if (curso == null)
            {
                return false;
            }
            _contexto.Cursos.Remove(curso);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Curso?> ListarPorIdAsync(int id)
        {
            return await _contexto.Cursos
                          .AsNoTracking()
                          .FirstOrDefaultAsync(x => x.CursoId == id);
        }

        public async Task<IEnumerable<Curso>> ListarTodosAsync()
        {
            return await _contexto.Cursos
                            .AsNoTracking()
                            .OrderBy(x => x.Nome)
                            .ToListAsync();
        }
    }
}
