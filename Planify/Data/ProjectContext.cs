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
        public DbSet<ProjectTaskComentary> Comentaries { get; set; }
        public DbSet<Permisions> Permisions { get; set; }
    }

    public partial class ProjectContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SetPersonTable(modelBuilder);
            SetUserTable(modelBuilder);
            SetEmployeeTable(modelBuilder);

            SetRoleTable(modelBuilder);
            SetProjectTable(modelBuilder);
            SetProjectTaskTable(modelBuilder);
            SetQueryFilters(modelBuilder);
            SetProjectTaskComentaryTable(modelBuilder);
            SetPermisionsTable(modelBuilder);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.Permisions)
            //    .WithMany(p => p.Users)
            //    .UsingEntity(j => j.HasData(
            //        new { UsersId = 1, PermisionsId = 1 },
            //        new { UsersId = 1, PermisionsId = 2 },
            //        new { UsersId = 1, PermisionsId = 3 },
            //        new { UsersId = 1, PermisionsId = 4 },
            //        new { UsersId = 2, PermisionsId = 2 }
            //    ));

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

            modelBuilder.Entity<ProjectTaskComentary>()
                .HasQueryFilter(p => !p.IsDeleted);

        }

        private void SetPersonTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.Name).HasColumnOrder(1);

                entity.HasData(
                    new Person()
                    {
                        Id = 1,
                        Name = "Jorguito",
                        City = "Guadalajara",
                        Country = "México",
                        LastNames = "Gerardo Rojo",
                        Sate = "Sinaloa"
                    },
                    new Person()
                    {
                        Id = 2,
                        Name = "Ana",
                        City = "Culiacan",
                        Country = "México",
                        LastNames = "Argon Lazaro",
                        Sate = "Sinaloa"
                    }
                );

            });
        }

        private void SetUserTable(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasData(
                    new User()
                    {
                        Id = 1,
                        Email = "Jorguito@hotmail.com",
                        //jorguito
                        HashPassword = "b88b88cd87cf54d08aabf61b73023cf35551850dc8da5a9d8ae410ef243f74ce"
                    },
                    new User()
                    {
                        Id = 2,
                        Email = "anitaanita@hotmail.com",
                        //anitaanita
                        HashPassword = "f0e50d441e11ee6fe5d8724d0e530e57df21f51d283009f7899b1ea47a26240e"
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

                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.Name).HasColumnOrder(1);
                entity.Property(p => p.ManagerId).HasColumnOrder(2);

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

                //Order
                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.Name).HasColumnOrder(1);
                entity.Property(p => p.Priority).HasColumnOrder(2);
                entity.Property(p => p.Status).HasColumnOrder(3);
                entity.Property(p => p.Description).HasColumnOrder(4);

                entity.HasData(
                    new ProjectTask()
                    {
                        Id = 1,
                        ProjectId = 1,
                        Name = "Actividad 1",
                        Priority = Priority.Critical,
                        Description = "Realizar ...",
                    }
                );
            });
        }

        private void SetRoleTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(roles =>
            {
                roles.Property(p => p.Id).HasColumnOrder(0);
                roles.Property(p => p.Name).HasColumnOrder(1);
            });
        }

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
                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.Name).HasColumnOrder(1);
                entity.Property(p => p.UserId).HasColumnOrder(2);
                entity.Property(p => p.PersonId).HasColumnOrder(3);
                entity.Property(p => p.HireDate).HasColumnOrder(4);

                entity.HasData(
                    new Employee()
                    {
                        Id = 1,
                        Name = "Jorguito",
                        PersonId = 1,
                        UserId = 1,
                        HireDate = DateOnly.FromDateTime(new DateTime(2022,5,1))
                    },
                    new Employee()
                    {
                        Id = 2,
                        Name = "Anita",
                        PersonId = 2,
                        UserId = 2,
                        HireDate = DateOnly.FromDateTime(new DateTime(2020, 11, 1))
                    }
                );
            });

        }

        private void SetProjectTaskComentaryTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTaskComentary>().ToTable("ProjectTaskComentaries");

            modelBuilder.Entity<ProjectTaskComentary>()
                .HasOne(ptc => ptc.ProjectTask)
                .WithMany(pt => pt.Comentaries)
                .HasForeignKey(ptc => ptc.ProjectTaskId);

            modelBuilder.Entity<ProjectTaskComentary>()
                .HasOne(ptc => ptc.Author)
                .WithMany()
                .HasForeignKey(ptc => ptc.EmployeeId);

            modelBuilder.Entity<ProjectTaskComentary>(entity =>
            {
                entity.Property(p => p.Comentary).HasMaxLength(255);

                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.ProjectTaskId).HasColumnOrder(1);
                entity.Property(p => p.EmployeeId).HasColumnOrder(2);
                entity.Property(p => p.Comentary).HasColumnOrder(3);
            });

        }

        private void SetPermisionsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisions>().HasData(
                    new Permisions { Id = 1, Name = "create", Description = "Permiso para crear." },
                    new Permisions { Id = 2, Name = "read", Description = "Permiso para leer." },
                    new Permisions { Id = 3, Name = "edit", Description = "Permiso para editar." },
                    new Permisions { Id = 4, Name = "delete", Description = "Permiso para eliminar." }
                );


            modelBuilder.Entity<User>()
                .HasMany(u => u.Permisions)
                .WithMany(p => p.Users)
                .UsingEntity(j => j.HasData(
                    new { UsersId = 1, PermisionsId = 1 },
                    new { UsersId = 1, PermisionsId = 2 },
                    new { UsersId = 1, PermisionsId = 3 },
                    new { UsersId = 1, PermisionsId = 4 },
                    new { UsersId = 2, PermisionsId = 2 }
                ));
        }
    }
}
