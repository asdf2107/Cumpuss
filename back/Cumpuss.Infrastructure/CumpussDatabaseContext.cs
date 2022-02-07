using Cumpuss.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Cumpuss.Infrastructure
{
    public partial class CumpussDatabaseContext : DbContext
    {
        public CumpussDatabaseContext() { }

        public CumpussDatabaseContext(DbContextOptions<CumpussDatabaseContext> options)
            : base(options) { }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupsToCourse> GroupsToCourses { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentsToCourse> StudentsToCourses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning move to config
                optionsBuilder.UseSqlServer("Data Source=.;Database=Cumpuss.Database;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Classes_ToCourses");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.YearSemester);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_ToSubjects");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.CoursesAsLecturer)
                    .HasForeignKey(d => d.LecturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_ToTeachers_Lecturer");

                entity.HasOne(d => d.PracticeTeacher)
                    .WithMany(p => p.CoursesAsPracticeTeacher)
                    .HasForeignKey(d => d.PracticeTeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_ToTeachers_PracticeTeacher");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grades_ToClasses");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grades_ToStudents");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(15);
            });

            modelBuilder.Entity<GroupsToCourse>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.CourseId })
                    .HasName("PK__GroupsTo__7808247042056DF9");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.GroupsToCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupsToCourses_ToCourses");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsToCourses)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupsToCourses_ToGroups");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Patronymic).HasMaxLength(30);

                entity.Property(e => e.Sirname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_ToGroups");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_ToPersons");
            });

            modelBuilder.Entity<StudentsToCourse>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseId })
                    .HasName("PK__Students__5E57FC838189A292");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentsToCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentsToCourses_ToCourses");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentsToCourses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentsToCourses_ToStudents");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teachers_ToPersons");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Face)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_ToFaces");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
