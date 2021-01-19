using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreFluentApi1
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        //public ICollection<Audit> Audits { get; set; } //You cannot add this to get All Audits.
    }

}
