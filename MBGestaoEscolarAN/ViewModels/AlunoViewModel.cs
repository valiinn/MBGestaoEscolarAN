using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.ViewModels
{
    public class AlunoViewModel
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "A matrícula é obrigatória")]
        [StringLength(20, ErrorMessage = "A matrícula deve ter no máximo 20 caracteres")]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; } = "";

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido")]
        [Display(Name = "CPF")]
        public string CPF { get; set; } = "";

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; } = "";

        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [StringLength(200, ErrorMessage = "O endereço deve ter no máximo 200 caracteres")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; } = "";

        [Required(ErrorMessage = "O status é obrigatório")]
        [Display(Name = "Status do Aluno")]
        public string StatusAluno { get; set; } = "";

        [Display(Name = "Data de Cadastro")]
        public DateTime? DataCadastro { get; set; }

        // Propriedades específicas da UI (adicione essas)
        public bool IsEdicao => AlunoId > 0;
        public string TituloFormulario => IsEdicao ? "Editar Aluno" : "Novo Aluno";
        public string TextoBotao => IsEdicao ? "Atualizar" : "Salvar";
    }

}
