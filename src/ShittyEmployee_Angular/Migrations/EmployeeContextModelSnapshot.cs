using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ShittyEmployee_Angular.Models;

namespace ShittyEmployee_Angular.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("ShittyEmployee_Angular.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Department");

                    b.Property<int>("Employed");

                    b.Property<string>("Name");

                    b.Property<int>("Salary");

                    b.Property<string>("Supervisor");

                    b.HasKey("Id");
                });
        }
    }
}
