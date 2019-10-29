using MarketModel;
using System.Data.Entity;

namespace MarketServiceImplementDataBase
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext() : base("MarketDataBase")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
