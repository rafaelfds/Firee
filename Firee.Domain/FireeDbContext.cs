using Firee.Domain.SysUser;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Firee.Domain
{
    public interface IDbContext
    {
        IDbSet<Supplier> Suppliers { get; set; }
        IDbSet<Product> Products { get; set; }

        int SaveChanges();
    }

    public class FireeDbContext : DbContext, IDbContext
    {
        public FireeDbContext() : base("Name=FireeConnectionString")
        {
            
        }

        public IDbSet<Supplier> Suppliers { get; set; }
        public IDbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            //var modifiedEntries = ChangeTracker.Entries()
            //    .Where(x => x.Entity is IAuditableEntity
            //        && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            //foreach (var entry in modifiedEntries)
            //{
            //    IAuditableEntity entity = entry.Entity as IAuditableEntity;
            //    if (entity != null)
            //    {
            //        string identityName = Thread.CurrentPrincipal.Identity.Name;
            //        DateTime now = DateTime.UtcNow;

            //        if (entry.State == System.Data.Entity.EntityState.Added)
            //        {
            //            entity.CreatedBy = identityName;
            //            entity.CreatedDate = now;
            //        }
            //        else
            //        {
            //            base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
            //            base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            //        }

            //        entity.UpdatedBy = identityName;
            //        entity.UpdatedDate = now;
            //    }
            //}

            return base.SaveChanges();
        }
    }

    public class FireeDatabaseInitializer : CreateDatabaseIfNotExists<FireeDbContext>
    {
        protected override void Seed(FireeDbContext context)
        {
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
