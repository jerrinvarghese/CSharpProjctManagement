using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.BusinessServices
{
    class EmployeeProject
    {
        public string EmployeeName { get; set; }
        public string Project { get; set; }
        public EmployeeProject()
        {
        }
        public EmployeeProject(string EmployeeName, string Project)
        {
            this.EmployeeName = EmployeeName;
            this.Project = Project;
        }
    }
}
