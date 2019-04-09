using Microsoft.EntityFrameworkCore;

namespace WebApiCoreEfCrud.Shared.Contexts.Funcionario
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
        {
        }

        //public DbSet<Funcionario> Funcionarios { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Funcionario>()
        //        .HasIndex(u => u.Id)
        //        .IsUnique();
        //}
    }
}