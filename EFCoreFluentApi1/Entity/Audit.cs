using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreFluentApi1
{
    public class Audit
    {
        public string AuditId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee ModEmployee { get; set; }
    }
}
