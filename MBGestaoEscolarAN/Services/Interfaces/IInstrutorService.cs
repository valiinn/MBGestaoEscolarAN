using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IInstrutorService
    {
        Task<IEnumerable<Instrutor>> ListarTodosAsync();
        Task<Instrutor> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Instrutor instrutor);
        Task<bool> AlterarAsync(Instrutor instrutor);
        Task<bool> ExcluirAsync(int id);
    }
}
