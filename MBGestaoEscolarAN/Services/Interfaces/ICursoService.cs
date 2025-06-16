using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> ListarTodosAsync();
        Task<Curso> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Curso curso);
        Task<bool> AlterarAsync(Curso curso);
        Task<bool> ExcluirAsync(int id);
    }
}
