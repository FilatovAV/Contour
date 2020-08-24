using Contour.Domain.Entities;
using System.Data.Entity;
using System.IO;

namespace Contour.DAL.Context
{
    class MainContext : DbContext
    {
        //private static readonly string cs = "name=ContourDbConnection";
        private static readonly string cs =
            $@"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename={Directory.GetCurrentDirectory()}\ContourData.mdf;Integrated Security = True";

        public MainContext() : base(cs)
        { }

        public virtual DbSet<ContourColor> ContourColors { get; set; }
        public virtual DbSet<Domain.Entities.Contour> Contours { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Purpose> Purposes { get; set; }
        public virtual DbSet<PurposeTypeName> PurposeTypeNames { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Contours)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Purposes)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(true);
        }
    }
}
