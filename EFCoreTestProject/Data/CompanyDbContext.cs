using EFCoreTestProject.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTestProject.Data
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }
        public DbSet<CompanyModel> Companies { get; set; }
    }
}
