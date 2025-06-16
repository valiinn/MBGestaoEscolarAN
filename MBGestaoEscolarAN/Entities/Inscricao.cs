using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Inscricao")]
    public class Inscricao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InscricaoId { get; set; }

        [Required]
        public int AlunoId { get; set; }

        [Required]
        public int TurmaId { get; set; }

        [Required]
        [Column(TypeName = "datetime2(3)")]
        public DateTime DataInscricao { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        // Navegação para Aluno
        [ForeignKey(nameof(AlunoId))]
        public Aluno Aluno { get; set; }

        // Navegação para Turma
        [ForeignKey(nameof(TurmaId))]
        public Turma Turma { get; set; }
    }
}
