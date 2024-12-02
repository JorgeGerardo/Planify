using Microsoft.EntityFrameworkCore;
using Planify.Models;
using System;
using System.Collections.Generic;

namespace Planify.Data
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

    public partial class ProjectContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SetPersonTable(modelBuilder);
            SetEmployeeTable(modelBuilder);
            
            SetRoleTable(modelBuilder);
            SetProjectTable(modelBuilder);
            SetProjectTaskTable(modelBuilder);
            SetQueryFilters(modelBuilder);
        }

        private void SetQueryFilters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Employee>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Person>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Project>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<ProjectTask>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Role>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<User>()
                .HasQueryFilter(p => !p.IsDeleted);

        }

        private void SetPersonTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasData(
                    new Person()
                    {
                        Id = 1,
                        Name = "Jorguito",
                        City = "Guadalajara",
                        Country = "México",
                        LastNames = "Gerardo Rojo",
                        Sate = "Sinaloa"
                    }
                );
            });
        }


        private void SetProjectTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity
                    .HasOne(p => p.Manager)
                    .WithMany()
                    .HasForeignKey(e => e.ManagerId)
                    .OnDelete(DeleteBehavior.Restrict);


                entity.HasData(
                    new Project()
                    {
                        Id = 1,
                        Name = "Loheed Martin Communication Software",
                        ManagerId = 1
                    }
                );
            });
        }

        private void SetProjectTaskTable(ModelBuilder modelBuilder)
        {
            //Foreign key:
            modelBuilder.Entity<ProjectTask>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.Property(p => p.Priority).HasConversion<string>();
                entity.Property(p => p.Status).HasConversion<string>();



                entity.HasData(
                    new ProjectTask()
                    {
                        Id = 1,
                        ProjectId = 1,
                        Name = "Actividad 1",
                        Priority = Priority.Critical,
                        Description = "Realizar ...",
                        Comments = new List<string>{
                            "Comentario 1",
                            "Comentario 2",
                            "Comentario 3",
                            "Comentario 4"
                        },

                    }
                );
            });
        }

        private void SetRoleTable(ModelBuilder modelBuilder) { }

        private void SetEmployeeTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithOne(e => e.User)
                .HasForeignKey<Employee>(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Person)
                .WithOne(p => p.Employee)
                .HasForeignKey<Employee>(e => e.PersonId);


            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasData(
                    new Employee()
                    {
                        Id = 1,
                        Name = "Jorguito",
                        PersonId = 1,
                        UserId = 1
                    }
                );
            });


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasData(
                    new User()
                    {
                        Id = 1,
                        Email = "Jorguito@hotmail.com",
                        //jorguito
                        HashPassword = "b88b88cd87cf54d08aabf61b73023cf35551850dc8da5a9d8ae410ef243f74ce"
                    }
                );
            });
        }
    
    }
}
