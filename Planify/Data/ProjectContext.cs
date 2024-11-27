using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

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

            SetEmployeeTable(modelBuilder);
            SetRoleTable(modelBuilder);
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

        private void SetRoleTable(ModelBuilder modelBuilder) { }

        private void SetEmployeeTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithOne(e => e.User)
                .HasForeignKey<Employee>(e => e.UserId);
        }
    }
}
