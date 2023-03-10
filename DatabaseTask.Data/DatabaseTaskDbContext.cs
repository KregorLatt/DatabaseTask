using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<EmployeeOps> Employee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Specialist> Specialist { get; set; }


    }
}
