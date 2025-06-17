using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.ViewModels
{
    public class MateriaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Turma é obrigatória.")]
        public int TurmaId { get; set; }

        [Required(ErrorMessage = "Instrutor é obrigatório.")]
        public int InstrutorId { get; set; }

        public bool IsEdicao => Id > 0;

        public string TextoBotao => IsEdicao ? "Salvar Alterações" : "Criar";

        public string TituloFormulario => IsEdicao ? "Editar Matéria" : "Nova Matéria";
    }
}
