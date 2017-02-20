using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ShowList.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //Added as extra user settings
        public string DisplayName { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string DefaultTab { get; set; }
        public bool MissedEp { get; set; }
        public bool Messages { get; set; }
        public ICollection<UserShow> ShowList { get; set; }
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

        //Initialize Dbsets
        public DbSet<Show> Shows { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<UserShow> UserShows { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /// <summary>
        /// OnModelCreating is a base method, but I have modified it to link all of my entities together
        /// In this model, I used compound keys for the episodes and linked them so that I could use the .include feature
        /// found in ASP.NET to have an object inherit a ICollection automatically
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Default User entity
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers")
                .HasKey(e => e.Id).HasMany(e => e.ShowList).WithRequired(l => l.User).HasForeignKey(e => e.UserID);
            //Show entity
            modelBuilder.Entity<Show>()
                .HasKey(e => e.ShowID).HasMany(e => e.Seasons).WithRequired(s => s.Show)
                .HasForeignKey(e => e.ShowID);

            //Season Entity needed 2 declarations due to issues with setting up multiple foreign keys
            modelBuilder.Entity<Season>().HasKey(e => new { e.ShowID, e.SeasonID })
                .HasRequired(e => e.Show).WithMany().HasForeignKey(e => new { e.ShowID, e.SeasonID });
            modelBuilder.Entity<Season>().HasMany(e => e.Episodes).WithRequired(s => s.Season)
                .HasForeignKey(e => new { e.ShowID, e.SeasonID });

            //Episode entity has a triple compound key
            modelBuilder.Entity<Episode>().HasKey(e => new { e.ShowID, e.SeasonID, e.EpisodeID })
                .HasRequired(e => e.Season).WithMany().HasForeignKey(e => new { e.ShowID, e.SeasonID, e.EpisodeID });

            //UserShow, again, needs 2 declarations due to multiple foreign key declaration
            modelBuilder.Entity<UserShow>().HasKey(e => new { e.UserID, e.ShowID }).HasRequired(e => e.User)
                .WithMany().HasForeignKey(e => e.UserID);
            modelBuilder.Entity<UserShow>().HasRequired(e => e.Show).WithMany().HasForeignKey(e => e.ShowID);
        }
    }
}