using Microsoft.EntityFrameworkCore;
using crud.Models;

namespace crud.Data
{
    public class CrudDbContext: DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options) { }
        public DbSet<crud.Models.Student> Student { get; set; }
        public DbSet<crud.Models.Teacher> Teacher { get; set; }
    }
}