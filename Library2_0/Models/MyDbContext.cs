using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2_0.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() : base("DbConnectionString")
        {

        }


        public DbSet<information> informations { get; set; }

    }
}
