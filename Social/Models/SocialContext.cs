using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;

namespace Social.Models
{
  public class SocialContext : IdentityDbContext<ApplicationUser>
  {
    public SocialContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<Post> Posts { get; set; }
    public virtual DbSet<Friend> Friends { get; set; }
    public virtual DbSet<ApplicationUser> Users { get; set; }
  }
}