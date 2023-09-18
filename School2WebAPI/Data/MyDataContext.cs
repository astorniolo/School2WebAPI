using Microsoft.EntityFrameworkCore;
using School2WebAPI.Entities;
using Microsoft.Extensions.Hosting;



namespace School2WebAPI.Data
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Teachers)
                .WithMany(e => e.Courses)
                .UsingEntity<OpenCourse>(
                    l => l.HasOne<Teacher>().WithMany(e => e.OpenCourses).HasForeignKey(e => e.TeacherId),
                    r => r.HasOne<Course>().WithMany(e => e.OpenCourses).HasForeignKey(e => e.CourseId)
                );

            modelBuilder.Entity<Student>()
                .HasMany(e => e.OpenCourses)
                .WithMany(e => e.Students)
                .UsingEntity<Inscription>(
                     l => l.HasOne<OpenCourse>().WithMany(e => e.Inscriptions).HasForeignKey(e => new { e.CourseId, e.TeacherId }),
                    s => s.HasOne<Student>().WithMany(e => e.Inscriptions).HasForeignKey(e => e.StudentId)
                );

            modelBuilder.Entity<Course>()
                .HasOne(e => e.ProgramContent)
                .WithOne(e => e.Course)
                .HasForeignKey<ProgramContent>(e => e.CourseId)
                .IsRequired();

            modelBuilder.Entity<AcademicArea>()
                .HasMany(e => e.Courses)
                .WithOne(e => e.AcademicArea)
                .HasForeignKey(e => e.AcademicAreaId)
               .IsRequired(false);
        }


      

        public DbSet<AcademicArea> AcademicAreas { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ProgramContent> ProgramContent { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<OpenCourse> OpenCourses { get; set; }
    }
}
