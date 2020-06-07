using Mercurius.Entities.Enums;
using System;

namespace Mercurius.Entities
{
    public class Employee : Person
    {
        public string EmployeeNumber { get; set; }
        public DateTime OnboardDate { get; set; }
        DepartmentEnum Department { get; set; }
    }
}
