﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planify.Data;

#nullable disable

namespace Planify.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("DepartmentEmployee");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeesId = 1,
                            ProjectsId = 1
                        },
                        new
                        {
                            EmployeesId = 2,
                            ProjectsId = 1
                        },
                        new
                        {
                            EmployeesId = 3,
                            ProjectsId = 1
                        },
                        new
                        {
                            EmployeesId = 4,
                            ProjectsId = 1
                        });
                });

            modelBuilder.Entity("EmployeeProjectTask", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("TasksId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("EmployeeProjectTask");

                    b.HasData(
                        new
                        {
                            EmployeesId = 2,
                            TasksId = 1
                        },
                        new
                        {
                            EmployeesId = 2,
                            TasksId = 2
                        },
                        new
                        {
                            EmployeesId = 3,
                            TasksId = 2
                        },
                        new
                        {
                            EmployeesId = 4,
                            TasksId = 2
                        },
                        new
                        {
                            EmployeesId = 2,
                            TasksId = 3
                        });
                });

            modelBuilder.Entity("Planify.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Planify.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("date")
                        .HasColumnOrder(4);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HireDate = new DateOnly(2022, 5, 1),
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jorguito",
                            PersonId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            HireDate = new DateOnly(2020, 11, 1),
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Anita",
                            PersonId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            HireDate = new DateOnly(2021, 12, 31),
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mariana",
                            PersonId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            HireDate = new DateOnly(2018, 12, 31),
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Anita",
                            PersonId = 4,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Planify.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BornDate")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BornDate = new DateOnly(1, 1, 1),
                            City = "Guadalajara",
                            Country = "México",
                            IsDeleted = false,
                            LastNames = "Gerardo Rojo",
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jorguito",
                            Sate = "Sinaloa"
                        },
                        new
                        {
                            Id = 2,
                            BornDate = new DateOnly(1, 1, 1),
                            City = "Culiacan",
                            Country = "México",
                            IsDeleted = false,
                            LastNames = "Argon Lazaro",
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ana",
                            Sate = "Sinaloa"
                        },
                        new
                        {
                            Id = 3,
                            BornDate = new DateOnly(1, 1, 1),
                            City = "Monterrey",
                            Country = "México",
                            IsDeleted = false,
                            LastNames = "Garza",
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mariana",
                            Sate = "Nuevo Leon"
                        },
                        new
                        {
                            Id = 4,
                            BornDate = new DateOnly(1, 1, 1),
                            City = "Mexicali",
                            Country = "México",
                            IsDeleted = false,
                            LastNames = "Duran",
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Antonella",
                            Sate = "Baja california"
                        });
                });

            modelBuilder.Entity("Planify.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerId = 1,
                            Name = "Lockheed Martin Communication Software"
                        });
                });

            modelBuilder.Entity("Planify.Models.ProjectTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly?>("CompleteDate")
                        .HasColumnType("time");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<DateOnly>("EstimatedEndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateUTC = new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3518),
                            Description = "Realizar ...",
                            EstimatedEndDate = new DateOnly(1, 1, 1),
                            IsCompleted = false,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Actividad 1",
                            Priority = "Critical",
                            ProjectId = 1,
                            StartDate = new DateOnly(1, 1, 1),
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateUTC = new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3524),
                            Description = "Ajustar los parámetros del modelo...",
                            EstimatedEndDate = new DateOnly(1, 1, 1),
                            IsCompleted = false,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Actividad 2",
                            Priority = "Medium",
                            ProjectId = 1,
                            StartDate = new DateOnly(1, 1, 1),
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateUTC = new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3526),
                            Description = "Realizar pruebas",
                            EstimatedEndDate = new DateOnly(1, 1, 1),
                            IsCompleted = false,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Actividad 3",
                            Priority = "Low",
                            ProjectId = 1,
                            StartDate = new DateOnly(1, 1, 1),
                            Status = "Pending"
                        });
                });

            modelBuilder.Entity("Planify.Models.ProjectTaskComentary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentary")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnOrder(3);

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectTaskId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectTaskId");

                    b.ToTable("ProjectTaskComentaries", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comentary = "Comentario 1",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 1,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9136))
                        },
                        new
                        {
                            Id = 2,
                            Comentary = "Comentario 2",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 2,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9146))
                        },
                        new
                        {
                            Id = 3,
                            Comentary = "Comentario 3",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 3,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9148))
                        },
                        new
                        {
                            Id = 4,
                            Comentary = "Comentario 4",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 4,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9149))
                        },
                        new
                        {
                            Id = 5,
                            Comentary = "Comentario 5",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 1,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9151))
                        },
                        new
                        {
                            Id = 6,
                            Comentary = "Comentario 6",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 2,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9191))
                        },
                        new
                        {
                            Id = 7,
                            Comentary = "Comentario 7",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 3,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9192))
                        },
                        new
                        {
                            Id = 8,
                            Comentary = "Comentario 8",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 4,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9194))
                        },
                        new
                        {
                            Id = 9,
                            Comentary = "Comentario 9",
                            Date = new DateOnly(2024, 12, 19),
                            EmployeeId = 1,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectTaskId = 1,
                            Time = new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9196))
                        });
                });

            modelBuilder.Entity("Planify.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "sa"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "admin"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "manager"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "rh-admin"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "rh"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "viewer"
                        });
                });

            modelBuilder.Entity("Planify.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedUTC")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Jorguito@example.com",
                            HashPassword = "b88b88cd87cf54d08aabf61b73023cf35551850dc8da5a9d8ae410ef243f74ce",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Email = "anitaanita@example.com",
                            HashPassword = "f0e50d441e11ee6fe5d8724d0e530e57df21f51d283009f7899b1ea47a26240e",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Email = "marianita@example.com",
                            HashPassword = "97f7ae522f40518794e1c7d2f0399f931a911b0f007f66fa2a24c65a262a9229",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Email = "antonella@example.com",
                            HashPassword = "6d2debd249a866cf0d19274260c7012b52725a404807dc8c5ef7e86d00ce8c03",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Email = "carlosmario@example.com",
                            HashPassword = "934f00dc360f0b00ba471007863910c1266f76244f136885715bce48334daaf7",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Email = "samueljuan@example.com",
                            HashPassword = "67a0978030e50d8f060cc216bc9ae8ea0e3fa38f0951cc412e5b41744f548add",
                            IsDeleted = false,
                            LastUpdatedUTC = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");

                    b.HasData(
                        new
                        {
                            RolesId = 1,
                            UsersId = 1
                        },
                        new
                        {
                            RolesId = 2,
                            UsersId = 2
                        },
                        new
                        {
                            RolesId = 3,
                            UsersId = 3
                        },
                        new
                        {
                            RolesId = 4,
                            UsersId = 4
                        },
                        new
                        {
                            RolesId = 5,
                            UsersId = 5
                        },
                        new
                        {
                            RolesId = 6,
                            UsersId = 6
                        });
                });

            modelBuilder.Entity("DepartmentEmployee", b =>
                {
                    b.HasOne("Planify.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("Planify.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeProjectTask", b =>
                {
                    b.HasOne("Planify.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.ProjectTask", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Planify.Models.Employee", b =>
                {
                    b.HasOne("Planify.Models.Person", "Person")
                        .WithOne("Employee")
                        .HasForeignKey("Planify.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("Planify.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Planify.Models.Project", b =>
                {
                    b.HasOne("Planify.Models.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Planify.Models.ProjectTask", b =>
                {
                    b.HasOne("Planify.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Planify.Models.ProjectTaskComentary", b =>
                {
                    b.HasOne("Planify.Models.Employee", "Author")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.ProjectTask", "ProjectTask")
                        .WithMany("Comentaries")
                        .HasForeignKey("ProjectTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("ProjectTask");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Planify.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Planify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Planify.Models.Person", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Planify.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Planify.Models.ProjectTask", b =>
                {
                    b.Navigation("Comentaries");
                });

            modelBuilder.Entity("Planify.Models.User", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
