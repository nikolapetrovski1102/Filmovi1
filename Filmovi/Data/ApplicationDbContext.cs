using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Filmovi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filmovi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Bileti> TicketsDb { get; set; }
        public DbSet<Kosna> CartDb { get; set; }
        public DbSet<Naracki> OrdersDb { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List<string>>().HasNoKey();
            modelBuilder.Entity<Tickets>().Ignore(t => t.GenreList);
        }
*/
    }
}