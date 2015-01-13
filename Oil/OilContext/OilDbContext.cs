using System.Data.Entity;
using DomainClasses;
using OilContext.Migrations;

namespace OilContext
{
    public class OilDbContext : DbContext,IUnitOfWork
    {
        public OilDbContext()
            :base ("OilDataBase")
        {
            
        }

        public DbSet<User> Users  { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }



        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
