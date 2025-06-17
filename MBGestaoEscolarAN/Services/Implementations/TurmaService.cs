using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaService : ITurmaService
    {
        private readonly SQLServerDbContext _contexto;

        public TurmaService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public Task<int> AdicionarAsync(Turma turma)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AlterarAsync(Turma turma)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Turma> ListarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Turma>> ListarTodosAsync()
        {
            return await Task.FromResult(new List<Turma>());
        }
    }
}
