using EdgarAparicio.APIAsyncRestFul.Manager.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIAsyncRestFul.Manager.Entity.Context
{
    public class DbContextAPIAsyncRestFullHostelCocos : DbContext
    {
        public DbContextAPIAsyncRestFullHostelCocos(DbContextOptions<DbContextAPIAsyncRestFullHostelCocos> options) : base(options)
        {

        }
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual DbSet<User> Users { get; set; }
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public virtual DbSet<Department> Departments { get; set; }
        /// <summary>
        /// Gets or sets the user department.
        /// </summary>
        /// <value>
        /// The user department.
        /// </value>
        public virtual DbSet<UserDepartment> UserDepartments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Edgar",
                    Age = 20,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new User()
                {
                    Id = 2,
                    Name = "Catalina",
                    Age = 54,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                });

            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    Id = 1,
                    Name = "Azul",
                    Level = 1,
                    Bedrooms = 3,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                });

            modelBuilder.Entity<UserDepartment>().HasData(
                new UserDepartment()
                {
                    Id = 1,
                    UserId = 1,
                    DepartmentId = 1,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                });

        }
    }
}
