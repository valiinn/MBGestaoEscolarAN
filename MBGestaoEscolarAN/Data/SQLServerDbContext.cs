using MBGestaoEscolarAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Data
{
    public class SQLServerDbContext : DbContext
    {
        public SQLServerDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Coordenador> Coordenadores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
    }
}
