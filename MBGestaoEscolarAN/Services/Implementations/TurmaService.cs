using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaService
    {
        private readonly SQLServerDbContext _contexto;

        public TurmaService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }
    }
}
