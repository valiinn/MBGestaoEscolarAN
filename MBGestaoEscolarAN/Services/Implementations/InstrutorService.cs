using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService : IInstrutorService
    {
        private readonly SQLServerDbContext _contexto;

        public InstrutorService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public Task<int> AdicionarAsync(Instrutor instrutor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AlterarAsync(Instrutor instrutor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Instrutor> ListarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<Instrutor>> ListarTodosAsync()
        {
            // Replace with actual logic to fetch data, e.g., from a database  
            return await Task.FromResult(new List<Instrutor>());
        }
    }
}
