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

        // Chave estrangeira para Turma
        [Required(ErrorMessage = "A turma é obrigatória")]
        public int TurmaId { get; set; }

        // Chave estrangeira para Instrutor
        [Required(ErrorMessage = "O instrutor é obrigatório")]
        public int InstrutorId { get; set; }

        [Required(ErrorMessage = "O nome da matéria é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A carga horária é obrigatória")]
        [Range(1, 1000, ErrorMessage = "A carga horária deve ser entre 1 e 1000.")]
        public int CargaHoraria { get; set; }

        [Required(ErrorMessage = "O peso da nota é obrigatório")]
        [Column(TypeName = "decimal(5, 2)")] // Define a precisão no banco de dados
        public decimal PesoNota { get; set; }


    }
}