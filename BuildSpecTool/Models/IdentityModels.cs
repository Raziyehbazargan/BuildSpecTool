using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BuildSpecTool.Models.ReferenceModels;

namespace BuildSpecTool.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Component> EventComponent { get; set; }
        public DbSet<AttendeeType> Ref_AttendeeType { get; set; }
        public DbSet<Client> Ref_Client { get; set; }
        public DbSet<ContentSection> Ref_ContentSections { get; set; }
        public DbSet<Mail> Ref_Mail { get; set; }
        public DbSet<SitePage> Ref_Page { get; set; }
        public DbSet<Status> Ref_Status { get; set; }
        public DbSet<Team> Ref_Team { get; set; }
        public DbSet<Role> Ref_Role { get; set; }
        public DbSet<EventAttendeeType> AttendeeType { get; set; }
        public DbSet<EventStatus> EventStatus { get; set; }
        public DbSet<EventPage> EventPages { get; set; }
    }
}