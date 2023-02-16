using Abp.EntityFrameworkCore;
using CapstoneProject.ESN.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.ESN.EntityFrameworkCore
{
    public class ESNDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        public ESNDbContext(DbContextOptions<ESNDbContext> options) 
            : base(options)
        {

        }
    }
}
