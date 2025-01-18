using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Files>Files { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet <Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
