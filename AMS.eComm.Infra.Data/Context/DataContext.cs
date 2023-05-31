using AMS.eComm.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Infra.Data.Context
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ): base (options)
        {
            
        }

        DbSet<Product> Product { get; set; }
        DbSet<ProductColor> ProductColor { get; set; }
        DbSet<Category> Category { get; set; }
    }
}
