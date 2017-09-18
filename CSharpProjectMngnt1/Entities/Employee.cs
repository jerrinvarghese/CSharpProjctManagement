using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Entities
{
    class Employee
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int Experience { get; set; }
        public int EmployeeAge { get; set; }

        public Employee()
        {
        }
        public Employee(int EmployeeCode, string EmployeeName, int Experience, int EmployeeAge)
        {
            this.EmployeeCode = EmployeeCode;
            this.EmployeeName = EmployeeName;
            this.Experience = Experience;
            this.EmployeeAge = EmployeeAge;
        }
    }
}
