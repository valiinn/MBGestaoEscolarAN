using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.ViewModels
{
    public class MateriaViewModel
    {
        public int MateriaId { get; set; }

        [Required(ErrorMessage = "A seleção da turma é obrigatória.")]
        [Display(Name = "Turma")]
        public int? TurmaId { get; set; } // Usar nullable para validação inicial

        [Required(ErrorMessage = "A seleção do instrutor é obrigatório.")]
        [Display(Name = "Instrutor")]
        public int? InstrutorId { get; set; } // Usar nullable para validação inicial

        [Required(ErrorMessage = "O nome da matéria é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome da Matéria")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "A carga horária é obrigatória")]
        [Range(1, 1000, ErrorMessage = "A carga horária deve ser válida.")]
        [Display(Name = "Carga Horária")]
        public int CargaHoraria { get; set; }

        [Required(ErrorMessage = "O peso da nota é obrigatório")]
        [Range(0.1, 10.0, ErrorMessage = "O peso da nota deve ser entre 0.1 e 10.0")]
        [Display(Name = "Peso da Nota")]
        public decimal PesoNota { get; set; }

        // Propriedades de UI
        public bool IsEdicao => MateriaId > 0;
        public string TituloFormulario => IsEdicao ? "Editar Matéria" : "Nova Matéria";
        public string TextoBotao => IsEdicao ? "Atualizar" : "Salvar";
    }
}