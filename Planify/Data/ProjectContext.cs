using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Services;
using System;

namespace Planify.Data
{
    // DB Set's
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
            SetDepartmentTable(modelBuilder);
        }

        private void SetDepartmentTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "RH"},
                new Department { Id = 2, Name = "DevOps"},
                new Department { Id = 3, Name = "TI"},
                new Department { Id = 4, Name = "Finance"}
            );

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithMany(e => e.Departments)
                .UsingEntity(i => i.HasData(
                    //RH
                    new { DepartmentsId = 3, EmployeesId = 1 },
                    new { DepartmentsId = 2, EmployeesId = 1 },
                    //DevOps
                    new { DepartmentsId = 1, EmployeesId = 2 },
                    new { DepartmentsId = 2, EmployeesId = 2 },

                    //DevOps-RH
                    new { DepartmentsId = 1, EmployeesId = 4 },
                    new { DepartmentsId = 2, EmployeesId = 4 },
                    
                    new { DepartmentsId = 1, EmployeesId = 5 },

                    //TI
                    new { DepartmentsId = 3, EmployeesId = 7 },
                    new { DepartmentsId = 3, EmployeesId = 8 },
                    new { DepartmentsId = 3, EmployeesId = 9 }
                   )
                );
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
                        Sate = "Sinaloa",
                        BornDate = new DateOnly(1985, 5, 23),
                    },
                    new Person()
                    {
                        Id = 2,
                        Name = "Ana",
                        City = "Culiacan",
                        Country = "México",
                        LastNames = "Argon Lazaro",
                        Sate = "Sinaloa",
                        BornDate = new DateOnly(1990, 3, 14),
                    },
                    new Person()
                    {
                        Id = 3,
                        Name = "Mariana",
                        City = "Monterrey",
                        Country = "México",
                        LastNames = "Garza",
                        Sate = "Nuevo Leon",
                        BornDate = new DateOnly(1992, 8, 12),
                    },
                    new Person()
                    {
                        Id = 4,
                        Name = "Antonella",
                        City = "Mexicali",
                        Country = "México",
                        LastNames = "Duran",
                        Sate = "Baja california",
                        BornDate = new DateOnly(1988, 6, 30),
                    },
                    new Person()
                    {
                        Id = 5,
                        Name = "Alexandra",
                        City = "Monterrey",
                        Country = "México",
                        LastNames = "Dorigan",
                        Sate = "Nuevo Leon",
                        BornDate = new DateOnly(1983, 9, 25),
                    },
                    new Person()
                    {
                        Id = 6,
                        Name = "Samuel Juan",
                        City = "Culiacán",
                        Country = "México",
                        LastNames = "Rodriguez Sandoval",
                        Sate = "Sinaloa",
                        BornDate = new DateOnly(1995, 1, 18),
                    },
                    new Person()
                    {
                        Id = 7,
                        Name = "Sebastian",
                        City = "Los Mochis",
                        Country = "México",
                        LastNames = "Pajarito Lopez",
                        Sate = "Sinaloa",
                        BornDate = new DateOnly(2000, 11, 5),
                    },
                    new Person()
                    {
                        Id = 8,
                        Name = "Brandon",
                        City = "El Fuerte",
                        Country = "México",
                        LastNames = "Perez Sánchez",
                        Sate = "Sinaloa",
                        BornDate = new DateOnly(1998, 7, 16),
                    },
                    new Person()
                    {
                        Id = 9,
                        Name = "Santiago",
                        City = "Durango",
                        Country = "México",
                        LastNames = "Ríos Gutiérrez",
                        Sate = "Durango",
                        BornDate = new DateOnly(1999, 2, 28),
                    }
                );

            });
        }

        private void SetUserTable(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {

                entity.HasData(
                    new User() //sa
                    {
                        Id = 1,
                        Email = "Jorguito@example.com",
                        HashPassword = AuthService.EncrypBySHA256("jorguito")
                    },
                    new User() //admin
                    {
                        Id = 2,
                        Email = "anitaanita@example.com",
                        HashPassword = AuthService.EncrypBySHA256("anitaanita")
                    },
                    new User() //manager
                    {
                        Id = 3,
                        Email = "marianita@example.com",
                        HashPassword = AuthService.EncrypBySHA256("marianita")
                    },
                    new User() //rh-admin
                    {
                        Id = 4,
                        Email = "antonella@example.com",
                        HashPassword = AuthService.EncrypBySHA256("antonella")
                    },
                    new User() //rh
                    {
                        Id = 5,
                        Email = "alexandra@example.com",
                        HashPassword = AuthService.EncrypBySHA256("alexandra")
                    },
                    new User() //viewer
                    {
                        Id = 6,
                        Email = "samueljuan@example.com",
                        HashPassword = AuthService.EncrypBySHA256("samueljuan")
                    },
                    new User() //Dev
                    {
                        Id = 7,
                        Email = "sebastian@example.com",
                        HashPassword = AuthService.EncrypBySHA256("sebastian")
                    },
                    new User() //Dev
                    {
                        Id = 8,
                        Email = "brandon@example.com",
                        HashPassword = AuthService.EncrypBySHA256("brandon")
                    },
                    new User() //Dev
                    {
                        Id = 9,
                        Email = "santiago@example.com",
                        HashPassword = AuthService.EncrypBySHA256("santiago")
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
                        Name = "Lockheed Martin Communication Software",
                        ManagerId = 1
                    }
                );
            });

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Employees)
                .WithMany(e => e.Projects)
                .UsingEntity(e => e.HasData(
                    new { EmployeesId = 1, ProjectsId = 1},
                    new { EmployeesId = 2, ProjectsId = 1},
                    new { EmployeesId = 3, ProjectsId = 1},
                    new { EmployeesId = 4, ProjectsId = 1}
                ));
        }

        private void SetProjectTaskTable(ModelBuilder modelBuilder)
        {
            //Foreign key:
            modelBuilder.Entity<ProjectTask>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Tasks)
                .WithMany(t => t.Employees)
                .UsingEntity(d => d.HasData(
                        //Actividad 1
                        new { EmployeesId = 2, TasksId = 1 },
                        //Actividad 2
                        new { EmployeesId = 2, TasksId = 2 },
                        new { EmployeesId = 3, TasksId = 2 },
                        new { EmployeesId = 4, TasksId = 2 },
                        //Actividad 3
                        new { EmployeesId = 2, TasksId = 3 }
                    ));


            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.Property(p => p.Priority).HasConversion<string>();
                entity.Property(p => p.Status).HasConversion<string>();

                //Order
                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.ProjectId).HasColumnOrder(1);
                entity.Property(p => p.Name).HasColumnOrder(2);
                entity.Property(p => p.Priority).HasColumnOrder(3);
                entity.Property(p => p.Status).HasColumnOrder(4);
                entity.Property(p => p.Description).HasColumnOrder(5);

                //TODO: Add StartDate and check models requirements
                entity.HasData(
                    new ProjectTask()
                    {
                        Id = 1,
                        ProjectId = 1,
                        Name = "Actividad 1",
                        Priority = Priority.Critical,
                        Description = "Realizar todas las pruebas unitarias correspondientes y pruebas de integración para garantizar la calidad de nuestro software",
                        StartDate = new DateOnly(2025, 2, 2),
                        EstimatedEndDate = new DateTime(2025, 2, 4)
                    },
                    new ProjectTask()
                    {
                        Id = 2,
                        ProjectId = 1,
                        Name = "Actividad 2",
                        Priority = Priority.Medium,
                        Description = "Ajustar los parámetros del modelo...",
                        StartDate = new DateOnly(2025, 2, 27),
                        EstimatedEndDate = new DateTime(2025, 3, 4)
                    },
                    new ProjectTask()
                    {
                        Id = 3,
                        ProjectId = 1,
                        Name = "Actividad 3",
                        Priority = Priority.Low,
                        Description = "Realizar pruebas",
                        StartDate = new DateOnly(2025, 2, 4),
                        EstimatedEndDate = new DateTime(2025, 2, 22)

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

                roles.HasData(
                    new Role { Id = 1, Name = "sa" },
                    new Role { Id = 2, Name = "admin" },
                    new Role { Id = 3, Name = "manager" },
                    new Role { Id = 4, Name = "rh-admin" },
                    new Role { Id = 5, Name = "rh" },
                    new Role { Id = 6, Name = "viewer" },
                    new Role { Id = 7, Name = "developer" }
                );

                modelBuilder.Entity<Role>()
                    .HasMany(u => u.Users)
                    .WithMany(u => u.Roles)
                    .UsingEntity(d => d.HasData(
                        new { UsersId = 1, RolesId = 1 },
                        new { UsersId = 2, RolesId = 2 },
                        new { UsersId = 3, RolesId = 3 },
                        new { UsersId = 4, RolesId = 4 },
                        new { UsersId = 5, RolesId = 5 },
                        new { UsersId = 6, RolesId = 6 },

                        //Devs:
                        new { UsersId = 7, RolesId = 7 },
                        new { UsersId = 8, RolesId = 7 },
                        new { UsersId = 9, RolesId = 7 }

                    ));

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
                entity.Property(p => p.Gender).HasConversion<string>();

                entity.Property(p => p.Id).HasColumnOrder(0);
                entity.Property(p => p.Name).HasColumnOrder(1);
                entity.Property(p => p.UserId).HasColumnOrder(2);
                entity.Property(p => p.PersonId).HasColumnOrder(3);
                entity.Property(p => p.HireDate).HasColumnOrder(4);

                entity.HasData(
                    new Employee()
                    {
                        Id = 1,
                        Name = "Jorge",
                        PersonId = 1,
                        UserId = 1,
                        HireDate = DateOnly.FromDateTime(new DateTime(2022, 5, 1)),
                        Gender = Gender.Male,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/men/97.jpg",
                    },
                    new Employee()
                    {
                        Id = 2,
                        Name = "Ana",
                        PersonId = 2,
                        UserId = 2,
                        HireDate = DateOnly.FromDateTime(new DateTime(2020, 11, 1)),
                        Gender = Gender.Female,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/women/95.jpg",
                    },
                    new Employee()
                    {
                        Id = 3,
                        Name = "Mariana",
                        PersonId = 3,
                        UserId = 3,
                        HireDate = DateOnly.FromDateTime(new DateTime(2021, 12, 31)),
                        Gender = Gender.Female,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/women/80.jpg",
                    },
                    new Employee()
                    {
                        Id = 4,
                        Name = "Antonella",
                        PersonId = 4,
                        UserId = 4,
                        HireDate = DateOnly.FromDateTime(new DateTime(2018, 12, 31)),
                        Gender = Gender.Female,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/women/96.jpg",
                    },
                    new Employee()
                    {
                        Id = 5,
                        Name = "Alexandra",
                        PersonId = 5,
                        UserId = 5,
                        HireDate = DateOnly.FromDateTime(new DateTime(2017, 5, 1)),
                        Gender = Gender.Female,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/women/88.jpg",
                    },
                    new Employee()
                    {
                        Id = 6,
                        Name = "Samuel Juan",
                        PersonId = 6,
                        UserId = 6,
                        HireDate = DateOnly.FromDateTime(new DateTime(2022, 6, 29)),
                        Gender = Gender.Male,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/men/88.jpg",
                    },
                    new Employee()
                    {
                        Id = 7,
                        Name = "Sebastian",
                        PersonId = 7,
                        UserId = 7,
                        HireDate = DateOnly.FromDateTime(new DateTime(2018, 4, 23)),
                        Gender = Gender.Male,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/men/88.jpg",
                    },
                    new Employee()
                    {
                        Id = 8,
                        Name = "Brandon",
                        PersonId = 8,
                        UserId = 8,
                        HireDate = DateOnly.FromDateTime(new DateTime(2023, 2, 27)),
                        Gender = Gender.Male,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/men/71.jpg",
                    },
                    new Employee()
                    {
                        Id = 9,
                        Name = "Santiago",
                        PersonId = 9,
                        UserId = 9,
                        HireDate = DateOnly.FromDateTime(new DateTime(2024, 2, 10)),
                        Gender = Gender.Male,
                        UrlProfileImage = @"https://randomuser.me/api/portraits/men/46.jpg",
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

            modelBuilder.Entity<ProjectTaskComentary>().HasData(
                new ProjectTaskComentary() { Id = 1, Comentary = "Comentario 1", EmployeeId = 1, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 2, Comentary = "Comentario 2", EmployeeId = 2, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 3, Comentary = "Comentario 3", EmployeeId = 3, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 4, Comentary = "Comentario 4", EmployeeId = 4, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 5, Comentary = "Comentario 5", EmployeeId = 1, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 6, Comentary = "Comentario 6", EmployeeId = 2, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 7, Comentary = "Comentario 7", EmployeeId = 3, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 8, Comentary = "Comentario 8", EmployeeId = 4, ProjectTaskId = 1 },
                new ProjectTaskComentary() { Id = 9, Comentary = "Comentario 9", EmployeeId = 1, ProjectTaskId = 1 }
            );

        }



    }

}
