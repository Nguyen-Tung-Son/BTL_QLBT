using System.Data.Entity;

namespace BTL_QLBT.Models
{
    public partial class QLBTDbContext : DbContext
    {
        public QLBTDbContext() : base("name=QLBTDbContext")
        {
        }
     
       // public virtual DbSet<Person> Persons { get; set; }
   
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

        }

        public System.Data.Entity.DbSet<BTL_QLBT.Models.Person> People { get; set; }
        public object Persons { get; internal set; }
    }
}