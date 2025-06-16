using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    public class Materia
    {

        public int Id { get; set; }

        public string Nome { get; set; }


        public int TurmaId { get; set; }
        public Turma Turma { get; set; }


        public int InstrutorId { get; set; }
        public Instrutor Instrutor { get; set; }
    }
}
