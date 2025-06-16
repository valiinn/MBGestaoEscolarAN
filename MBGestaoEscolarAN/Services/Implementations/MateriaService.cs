using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using MBGestaoEscolarAN.Services.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class MateriaService : IMateriaService
    {
        private readonly IMateriaRepository _materiaRepository;

        public MateriaService(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        public async Task<IEnumerable<Materia>> ListarTodosAsync()
        {
            return await _materiaRepository.ListarTodosAsync();
        }

        public async Task<Materia> ListarPorIdAsync(int id)
        {
            return await _materiaRepository.ListarPorIdAsync(id);
        }

        public async Task AdicionarAsync(Materia materia)
        {
            await _materiaRepository.AdicionarAsync(materia);
        }

        public async Task AlterarAsync(Materia materia)
        {
            await _materiaRepository.AlterarAsync(materia);
        }

        public async Task ExcluirAsync(int id)
        {
            await _materiaRepository.ExcluirAsync(id);
        }
    }
}
