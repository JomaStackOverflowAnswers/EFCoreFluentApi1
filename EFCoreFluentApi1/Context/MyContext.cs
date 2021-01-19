using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreFluentApi1.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Audit> Audit { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public MyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>().HasKey(e => e.EmployeeId);
            builder.Entity<Employee>().Property(e => e.EmployeeId);

            builder.Entity<Audit>().HasKey(e => e.AuditId);
            builder.Entity<Audit>().Property(e => e.AuditId).IsRequired();//Compatible IsRequired
            builder.Entity<Audit>().HasOne(e => e.ModEmployee).WithMany().HasForeignKey(e => e.EmployeeId);

            builder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee{ EmployeeId = 1 },
                new Employee{ EmployeeId = 2 },
                new Employee{ EmployeeId = 3 },
                new Employee{ EmployeeId = 4 }
            });

            builder.Entity<Audit>().HasData(
                new Audit[]
                {
                    new Audit
                    {
                        AuditId = "Audit1",
                        EmployeeId = 1
                    },
                    new Audit
                    {
                        AuditId = "Audit2",
                        EmployeeId = 1
                    },
                    new Audit
                    {
                        AuditId = "Audit3",
                        EmployeeId = 1
                    },
                    new Audit
                    {
                        AuditId = "Audit4",
                        EmployeeId = 2
                    },
                    new Audit
                    {
                        AuditId = "Audit5",
                        EmployeeId = 3
                    },
                    new Audit
                    {
                        AuditId = "Audit6",
                        EmployeeId = 3
                    },
                    new Audit
                    {
                        AuditId = "Audit7",
                        EmployeeId = 4
                    },
                    new Audit
                    {
                        AuditId = "Audit8",
                        EmployeeId = 4
                    },
                    new Audit
                    {
                        AuditId = "Audit9",
                        EmployeeId = 4
                    },
                    new Audit
                    {
                        AuditId = "Audit10",
                        EmployeeId = 4
                    }

                });
        }

        public ICollection<Audit> GetAudits(int employeeId)
        {
            return Audit.Where(e => e.EmployeeId == employeeId).ToList();
        }

    }
}
