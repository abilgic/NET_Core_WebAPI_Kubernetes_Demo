using Microsoft.EntityFrameworkCore;

namespace NET_Core_WebAPI_Kubernetes_Demo.Models
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass>
options) : base(options)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
