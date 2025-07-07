using AutomatedBackUpReport.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomatedBackUpReport.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<HCTest> hCTests { get; set; }
    }
}
