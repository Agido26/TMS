using System;
using Microsoft.EntityFrameworkCore;
using TMS.Domain.Entities.People;

namespace TMS.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Person> People { get; set; }
    }
}
