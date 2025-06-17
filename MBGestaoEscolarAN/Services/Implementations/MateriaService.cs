using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class MateriaService : IMateriaService
    {
        private readonly SQLServerDbContext _context;

        public MateriaService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Materia>> ListarTodosAsync()
        {
            return await _context.Materias
                           .AsNoTracking()
                           .OrderBy(x => x.Nome)
                           .ToListAsync();
        }

        public async Task<Materia?> ListarPorIdAsync(int id)
        {
            return await _context.Materias
                .AsNoTracking()
                .Include(m => m.Turma)
                .Include(m => m.Instrutor)
                .FirstOrDefaultAsync(m => m.MateriaId == id);
        }

        public async Task<int> AdicionarAsync(Materia materia)
        {
            await _context.Materias.AddAsync(materia);
            await _context.SaveChangesAsync();
            return materia.MateriaId;
        }

        public async Task AlterarAsync(Materia materia)
        {
            _context.Materias.Update(materia);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia is not null)
            {
                _context.Materias.Remove(materia);
                await _context.SaveChangesAsync();
            }
        }

        Task IMateriaService.AdicionarAsync(Materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
