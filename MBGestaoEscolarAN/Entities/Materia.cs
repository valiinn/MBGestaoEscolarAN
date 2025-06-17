using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MateriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int TurmaId { get; set; }

        [ForeignKey("TurmaId")]
        public Turma Turma { get; set; }

        [Required]
        public int InstrutorId { get; set; }

        [ForeignKey("InstrutorId")]
        public Instrutor Instrutor { get; set; }

        [Required]
        [Range(1, 1000)]
        public int CargaHoraria { get; set; }

        [Required]
        [Range(0.0, 10.0)]
        public double PesoNota { get; set; }
    }
}
