using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Aluno")]
    public class Aluno : Pessoa
    {
        public Aluno()
        {
        }

        public Aluno(string matricula, DateTime? dataNascimento)
        {
            Matricula = matricula;
            DataNascimento = dataNascimento;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlunoId { get; set; }
        [Required]
        [StringLength(40)]
        public string Matricula { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataNascimento { get; set; }
        [StringLength(500)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(40)]
        public string StatusAluno { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataCadastro { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();


    }
}
