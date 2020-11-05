using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Kitapcim.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("UyelikBaglantisi")
        {
        }

        public DbSet<ApplicationRoleViewModel> ApplicationRoleViewModels { get; set; }

        public System.Data.Entity.DbSet<Kitapcim.Models.Kullanici> Kullanici { get; set; }
    }
}