using Microsoft.EntityFrameworkCore;
using static TestApplication.Models.TestDbModel;

namespace TestApplication.Models
{
    public class TestDbContext:DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }
        public virtual DbSet<XXIBM_PRODUCT_SKU> XXIBM_PRODUCT_SKU { get; set; }
        public virtual DbSet<XXIBM_PRODUCT_CATALOGUE> XXIBM_PRODUCT_CATALOGUE { get; set; }
        public virtual DbSet<XXIBM_PRODUCT_PRICING> XXIBM_PRODUCT_PRICING { get; set; }
        public virtual DbSet<XXIBM_PRODUCT_STYLE> XXIBM_PRODUCT_STYLE { get; set; }
    }
}
