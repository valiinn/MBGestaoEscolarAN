using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class MateriaService : IMateriaService
    {
        private readonly SQLServerDbContext _contexto;

        public MateriaService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Materia materia)
        {
            _contexto.Materias.Add(materia);
            await _contexto.SaveChangesAsync();
            return materia.MateriaId;
        }

        public async Task<bool> AlterarAsync(Materia materia)
        {
            var materiaExiste = await _contexto.Materias.FindAsync(materia.MateriaId);
            if (materiaExiste == null)
            {
                return false;
            }
            _contexto.Entry(materiaExiste).CurrentValues.SetValues(materia);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var materia = await _contexto.Materias.FindAsync(id);
            if (materia == null)
            {
                return false;
            }
            _contexto.Materias.Remove(materia);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Materia?> ListarPorIdAsync(int id)
        {
            return await _contexto.Materias
                                  .AsNoTracking()
                                  .FirstOrDefaultAsync(x => x.MateriaId == id);
        }

        public async Task<IEnumerable<Materia>> ListarTodosAsync()
        {
            return await _contexto.Materias
                                  .AsNoTracking()
                                  .OrderBy(x => x.Nome)
                                  .ToListAsync();
        }
    }
}