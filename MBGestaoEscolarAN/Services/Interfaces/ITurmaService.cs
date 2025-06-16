using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ITurmaService
    {
        Task<IEnumerable<Turma>> ListarTodosAsync();
        Task<Turma> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Turma turma);
        Task<bool> AlterarAsync(Turma turma);
        Task<bool> ExcluirAsync(int id);
    }
}
