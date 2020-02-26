using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ServiceRequestInformationSystem.Models
{
    public class SrisContext : DbContext
    {
        public SrisContext()
           : base("SrisContext")
        {
            Database.SetInitializer<SrisContext>(new SrisDbInitializer());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SrisContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<ServiceRequestInfo> ServiceRequestInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceRequestInfo>().HasKey(k => k.SR_ID)
                .Property(p => p.SR_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ServiceProvidedBy>().HasKey(k => k.SP_ID)
              .Property(p => p.SP_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TypeOfService>().HasKey(k => k.TS_ID)
             .Property(p => p.TS_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<OfficeDepartment>().HasKey(k => k.OD_ID)
           .Property(p => p.OD_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<RemarkInfo>().HasKey(k => k.Remark_ID)
          .Property(p => p.Remark_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<ServiceRequestInfo>()
              .HasRequired<TypeOfService>(k => k.TypeOfService)
              .WithMany(p => p.ServiceRequestInfo)
              .HasForeignKey<int>(k => k.TS_ID);

            modelBuilder.Entity<ServiceRequestInfo>()
              .HasRequired<OfficeDepartment>(k => k.OfficeDepartment)
              .WithMany(p => p.ServiceRequestInfo)
              .HasForeignKey<int>(k => k.OD_ID);


            modelBuilder.Entity<ServiceRequestInfo>()
             .HasRequired<ServiceProvidedBy>(k => k.ServiceProvidedBy)
             .WithMany(p => p.ServiceRequestInfo)
             .HasForeignKey<int>(k => k.SP_ID);

            modelBuilder.Entity<ServiceRequestInfo>()
            .HasRequired<RemarkInfo>(k => k.RemarkInfo)
            .WithMany(p => p.ServiceRequestInfo)
            .HasForeignKey<int>(k => k.Remark_ID);
        }
    }

}