namespace DAL_EF.Migrations
{
    using DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.FileDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.FileDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.Add(new User() { UserName = "admin", Email = "admin@gmail.com", Password = "123456" });
            context.Users.Add(new User() { UserName = "user", Email = "user@gmail.com", Password = "123456" });
            context.Users.Add(new User() { UserName = "datta", Email = "datta@gmail.com", Password = "123456" });

            context.Roles.Add(new Role() { RoleName = "admin" });
            context.Roles.Add(new Role() { RoleName = "user" });

            context.UserRoles.Add(new UserRole() { UserId = 1, RoleId = 1 });
            context.UserRoles.Add(new UserRole() { UserId = 2, RoleId = 2 });
            context.UserRoles.Add(new UserRole() { UserId = 3, RoleId = 2 });
            context.SaveChanges();
        }
    }
}
