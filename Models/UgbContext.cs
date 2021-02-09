using System.Data.Entity;

namespace Ugb.Models
{
    public class UgbContext : DbContext
    {
        public UgbContext() : base("Name=AlunosDb")
        {
            Database.SetInitializer<UgbContext>(
                new CreateDatabaseIfNotExists<UgbContext>());
            Database.Initialize(false);

            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}