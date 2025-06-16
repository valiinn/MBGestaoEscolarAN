using MBGestaoEscolarAN.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IMateriaService
    {
        Task<IEnumerable<Materia>> ListarTodosAsync();
        Task<Materia> ListarPorIdAsync(int id);
        Task AdicionarAsync(Materia materia);
        Task AlterarAsync(Materia materia);
        Task ExcluirAsync(int id);
    }
}
