using EntityFrameworkExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample.DbContexts
{
    public class TrainingContext:DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingContext()
        {
            _connectionString = ConnectionStringReader.connectionString;
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString, 
                    m => m.MigrationsAssembly(_assemblyName)
                );

                base.OnConfiguring(dbContextOptionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudents>().HasKey(cs => new { cs.CourseId, cs.StudentId});

            modelBuilder.Entity<Course>().HasMany(p => p.Topics).WithOne(c => c.Course);

            modelBuilder.Entity<CourseStudents>().HasOne(d => d.Coure).WithMany(e => e.CourseStudents).HasForeignKey(f => f.CourseId);

            modelBuilder.Entity<CourseStudents>().HasOne(s => s.Student).WithMany(t => t.StudentsCourse).HasForeignKey(r => r.StudentId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
