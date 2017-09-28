namespace Week06.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Week06Model : DbContext
    {
        public Week06Model()
            : base("name=Books")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Images)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);
        }
    }
}
