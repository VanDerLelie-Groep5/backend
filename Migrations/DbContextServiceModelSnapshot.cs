﻿// <auto-generated />
using System;
using Groep5_Van_Der_Lelie_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Groep5VanDerLelieApi.Migrations
{
    [DbContext(typeof(DbContextService))]
    partial class DbContextServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CocNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cocNumber");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("company");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("customerNumber");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("emailAddress");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastName");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phoneNumber");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("DepartmentNumber")
                        .HasColumnType("int")
                        .HasColumnName("departmentNumber");

                    b.Property<int?>("MaxEmployees")
                        .HasColumnType("int")
                        .HasColumnName("maxEmployees");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentNumber")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("emailAddress");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("employeeNumber");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastName");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phoneNumber");

                    b.Property<int?>("PreferenceDepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("preferenceDepartmentId");

                    b.Property<double>("UnitsPerHour")
                        .HasColumnType("float")
                        .HasColumnName("unitsPerHour");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNumber")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.EmployeeShift", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employeeId");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int")
                        .HasColumnName("shiftId");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.Property<DateTime>("endDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("endDateTime");

                    b.Property<DateTime>("startDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("startDateTime");

                    b.HasKey("EmployeeId", "ShiftId");

                    b.HasIndex("ShiftId");

                    b.ToTable("EmployeeShift");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<string>("CustomerGroup")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("customerGroup");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FabricName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fabricName");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("orderNumber");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("priority");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("product");

                    b.Property<DateTime?>("Ready")
                        .HasColumnType("datetime2")
                        .HasColumnName("ready");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reference");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int")
                        .HasColumnName("shiftId");

                    b.Property<string>("Space")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("space");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<float?>("Units")
                        .HasColumnType("real")
                        .HasColumnName("units");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.Property<DateTime?>("entryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("entryDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("departmentId");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("endDateTime");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("startDateTime");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.EmployeeShift", b =>
                {
                    b.HasOne("Groep5_Van_Der_Lelie_Api.Models.Employee", "Employee")
                        .WithMany("EmployeeShifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Groep5_Van_Der_Lelie_Api.Models.Shift", "Shift")
                        .WithMany("EmployeesShifts")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Order", b =>
                {
                    b.HasOne("Groep5_Van_Der_Lelie_Api.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Groep5_Van_Der_Lelie_Api.Models.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Shift", b =>
                {
                    b.HasOne("Groep5_Van_Der_Lelie_Api.Models.Department", "Department")
                        .WithMany("Shifts")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Department", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Employee", b =>
                {
                    b.Navigation("EmployeeShifts");
                });

            modelBuilder.Entity("Groep5_Van_Der_Lelie_Api.Models.Shift", b =>
                {
                    b.Navigation("EmployeesShifts");
                });
#pragma warning restore 612, 618
        }
    }
}
