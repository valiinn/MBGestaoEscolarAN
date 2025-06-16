namespace MBGestaoEscolarAN.Entities
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local { get; set; }
        public string Modalidade { get; set; }
        public int NumeroVagas { get; set; }
        public string StatusTurma { get; set; }
    }
}
