using System.Data.Entity;
using Entity.Models;

namespace Entity.Context
{
    public class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

        public Context() : base("Name=WebPetDb"){}

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
