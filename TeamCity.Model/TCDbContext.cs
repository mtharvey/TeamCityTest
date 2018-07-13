namespace TeamCity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TCDbContext : DbContext
    {
        public TCDbContext()
            : base("name=TCDbContext")
        {
        }

        public virtual DbSet<DbInfo> DbInfoes { get; set; }
        public virtual DbSet<MessageLog> MessageLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbInfo>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<MessageLog>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<MessageLog>()
                .Property(e => e.Message)
                .IsUnicode(false);
        }
    }
}
