using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICoordenadorService
    {
        Task<IEnumerable<Coordenador>> ListarTodosAsync();
        Task<Coordenador?> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Coordenador coordenador);
        Task<bool> AlterarAsync(Coordenador coordenador);
        Task<bool> ExcluirAsync(int id);
    }
}
