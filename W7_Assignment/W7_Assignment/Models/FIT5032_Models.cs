namespace W7_Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FIT5032_Models : DbContext
    {
        public FIT5032_Models()
            : base("name=FIT5032_Models")
        {
        }

        public virtual DbSet<UserInfor> UserInfor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfor>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfor>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfor>()
                .Property(e => e.UserId)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<W7_Assignment.Models.Hall> Halls { get; set; }
    }
}
