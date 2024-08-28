using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasKey(s => s.StudentId);

        modelBuilder.Entity<Enrollment>()
            .HasKey(e => e.EnrollmentId);

        modelBuilder.Entity<Student>()
            .HasMany(s => s.Enrollments)
            .WithOne(e => e.Student)
            .HasForeignKey(e => e.StudentId);
    }
}
