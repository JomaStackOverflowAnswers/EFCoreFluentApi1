﻿// <auto-generated />
using EFCoreFluentApi1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreFluentApi1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210119043201_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreFluentApi1.Audit", b =>
                {
                    b.Property<string>("AuditId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("AuditId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Audit");

                    b.HasData(
                        new
                        {
                            AuditId = "Audit1",
                            EmployeeId = 1
                        },
                        new
                        {
                            AuditId = "Audit2",
                            EmployeeId = 1
                        },
                        new
                        {
                            AuditId = "Audit3",
                            EmployeeId = 1
                        },
                        new
                        {
                            AuditId = "Audit4",
                            EmployeeId = 2
                        },
                        new
                        {
                            AuditId = "Audit5",
                            EmployeeId = 3
                        },
                        new
                        {
                            AuditId = "Audit6",
                            EmployeeId = 3
                        },
                        new
                        {
                            AuditId = "Audit7",
                            EmployeeId = 4
                        },
                        new
                        {
                            AuditId = "Audit8",
                            EmployeeId = 4
                        },
                        new
                        {
                            AuditId = "Audit9",
                            EmployeeId = 4
                        },
                        new
                        {
                            AuditId = "Audit10",
                            EmployeeId = 4
                        });
                });

            modelBuilder.Entity("EFCoreFluentApi1.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1
                        },
                        new
                        {
                            EmployeeId = 2
                        },
                        new
                        {
                            EmployeeId = 3
                        },
                        new
                        {
                            EmployeeId = 4
                        });
                });

            modelBuilder.Entity("EFCoreFluentApi1.Audit", b =>
                {
                    b.HasOne("EFCoreFluentApi1.Employee", "ModEmployee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
