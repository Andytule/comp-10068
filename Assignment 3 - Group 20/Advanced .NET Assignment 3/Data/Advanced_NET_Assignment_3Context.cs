using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Advanced_.NET_Assignment_3.Models;

namespace Advanced_.NET_Assignment_3.Data
{
    public class Advanced_NET_Assignment_3Context : DbContext
    {
        public Advanced_NET_Assignment_3Context (DbContextOptions<Advanced_NET_Assignment_3Context> options)
            : base(options)
        {
        }

        public DbSet<Immunization> Immunization { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Advanced_.NET_Assignment_3.Models.Organization> Organization { get; set; }
    }
}
