using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IMateriaService
    {
        Task<IEnumerable<Materia>> ListarTodosAsync();
        Task<Materia> ListarPorIdAsync(int id);
        Task<int> AdicionarAsync(Materia materia);
        Task<bool> AlterarAsync(Materia materia);
        Task<bool> ExcluirAsync(int id);
    }
}
