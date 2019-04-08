namespace CRUDwithMVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRUDbdmodel : DbContext
    {
        public CRUDbdmodel()
            : base("name=CRUDbdmodel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.position)
                .IsUnicode(false);
        }
    }
}
