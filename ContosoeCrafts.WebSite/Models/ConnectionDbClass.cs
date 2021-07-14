using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContosoeCrafts.WebSite.Models
{
    public class ConnectionDbClass:DbContext

    {
        public ConnectionDbClass(DbContextOptions<ConnectionDbClass> options):base(options)
        {

        }
        public DbSet<Product> Product { get; set; }

    }
}
