using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ugb.Models
{
    public class UgbContext : DbContext
    {
        public UgbContext() : base("Name=Ugb_db")
        {
            Database.SetInitializer<UgbContext>(
                new CreateDatabaseIfNotExists<UgbContext>());
            Database.Initialize(false);

            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}