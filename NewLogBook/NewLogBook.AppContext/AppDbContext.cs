using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewLogBook.Entities;

namespace NewLogBook.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSubject> TeachersSubjects { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Faculty>().HasMany(z => z.Groups).WithOne();
            builder.Entity<Group>().HasOne(z => z.Faculty)
                .WithMany(x => x.Groups).HasForeignKey(z => z.FacultyId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Student>().HasOne(z => z.Group).WithMany(x => x.Students)
                .HasForeignKey(z => z.GroupId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Departament>().HasMany(z => z.Teachers).WithOne();
            builder.Entity<Mark>().HasOne(z => z.Student).WithMany(x => x.Marks)
                .HasForeignKey(z => z.StudentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Mark>().HasOne(z => z.TeacherSubject).WithMany(x => x.Marks)
                .HasForeignKey(z => z.TeacherSubjectId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Subject>().HasMany(z => z.TeachersSubjects).WithOne();
            builder.Entity<Teacher>().HasOne(z => z.Departament).WithMany(x => x.Teachers)
                .HasForeignKey(z => z.DepartamentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Teacher>().HasMany(z => z.TeacherSubjects).WithOne();
            builder.Entity<TeacherSubject>().HasOne(z => z.Teacher).WithMany(x => x.TeacherSubjects)
                .HasForeignKey(z => z.TeacherId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TeacherSubject>().HasOne(z => z.Subject).WithMany(x => x.TeachersSubjects)
                .HasForeignKey(z => z.SubjectId).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(builder);
            builder.Entity<Faculty>().HasData(
                new Faculty
                {
                    Id = 1,
                    Name = "Programming",
                },
                new Faculty
                {
                    Id = 2,
                    Name = "System administration and security",
                },
                new Faculty
                {
                    Id = 3,
                    Name = "Disign",

                },
                new Faculty
                {
                    Id = 5,
                    Name = "Base",
                });

            builder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "PP-12-1", FacultyId = 1 },
                new Group { Id = 2, Name = "PP-12-2", FacultyId = 1 },
                new Group { Id = 3, Name = "PP-12-3", FacultyId = 1 },
                new Group { Id = 4, Name = "PP-12-4", FacultyId = 1 });
        }
    }
}
