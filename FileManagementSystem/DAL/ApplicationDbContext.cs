using DAL.Entities;
using System.Data.Entity;

namespace DAL
{
    public class FileDbContext:DbContext
    {
        public DbSet<Files> Files { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
