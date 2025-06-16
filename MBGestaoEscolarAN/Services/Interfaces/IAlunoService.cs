using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> ListarTodosAsync();
        Task<Aluno?> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Aluno aluno);
        Task<bool> AlterarAsync(Aluno aluno);
        Task<bool> ExcluirAsync(int id);
    }
}
