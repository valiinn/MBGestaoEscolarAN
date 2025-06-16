using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.ViewModels
{
    public class CursoViewModel
    {
        public int CursoId { get; set; }

        [Required(ErrorMessage = "O nome do curso é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome do Curso")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "O código do curso é obrigatório")]
        [StringLength(20, ErrorMessage = "O código deve ter no máximo 20 caracteres")]
        [Display(Name = "Código")]
        public string Codigo { get; set; } = "";

        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = "";

        [Required(ErrorMessage = "A carga horária é obrigatória")]
        [Range(1, 10000, ErrorMessage = "A carga horária deve ser maior que 0")]
        [Display(Name = "Carga Horária (h)")]
        public int CargaHoraria { get; set; }

        [Required(ErrorMessage = "A modalidade é obrigatória")]
        [Display(Name = "Modalidade")]
        public string Modalidade { get; set; } = "";

        [Display(Name = "Trilha")]
        [StringLength(100, ErrorMessage = "A trilha deve ter no máximo 100 caracteres")]
        public string Trilha { get; set; } = "";

        [Required(ErrorMessage = "Os pontos CAP são obrigatórios")]
        [Range(0, 1000, ErrorMessage = "Os pontos CAP devem estar entre 0 e 1000")]
        [Display(Name = "Pontos CAP")]
        public int PontosCap { get; set; }

        [Required(ErrorMessage = "O status do curso é obrigatório")]
        [Display(Name = "Status do Curso")]
        public string StatusCurso { get; set; } = "";

        [Required(ErrorMessage = "O coordenador é obrigatório")]
        [Display(Name = "Coordenador")]
        public int CoordenadorId { get; set; }

        // Propriedades auxiliares para a interface
        public bool IsEdicao => CursoId > 0;
        public string TituloFormulario => IsEdicao ? "Editar Curso" : "Novo Curso";
        public string TextoBotao => IsEdicao ? "Atualizar" : "Salvar";
    }
}
