using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace MBGestaoEscolarAN.Service.Implementations
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
            return await _context.Materias.Include(m => m.Turma).Include(m => m.Instrutor).ToListAsync();
        }

        public async Task<Materia> ListarPorIdAsync(int id)
        {
            return await _context.Materias
                .Include(m => m.Turma)
                .Include(m => m.Instrutor)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AdicionarAsync(Materia materia)
        {
            await _context.Materias.AddAsync(materia);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Materia materia)
        {
            _context.Materias.Update(materia);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia != null)
            {
                _context.Materias.Remove(materia);
                await _context.SaveChangesAsync();
            }
        }

        Task<int> IMateriaService.AdicionarAsync(Materia materia)
        {
            throw new NotImplementedException();
        }

        Task<bool> IMateriaService.AlterarAsync(Materia materia)
        {
            throw new NotImplementedException();
        }

        Task<bool> IMateriaService.ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
