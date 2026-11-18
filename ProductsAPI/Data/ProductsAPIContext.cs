using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Data
{
    public class ProductsAPIContext : DbContext
    {
        public ProductsAPIContext (DbContextOptions<ProductsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsAPI.Data.Product> Product { get; set; } = default!;
    }
}
