using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.BusinessServices
{
    class EmployeeSkills
    {
        public string EmployeeName { get; set; }
        public int EmployeeExperience { get; set; }
        public string SkillName { get; set; }
        public EmployeeSkills()
        {
        }
        public EmployeeSkills(string EmployeeName, string SkillName, int EmployeeExperience)
        {
            this.EmployeeName = EmployeeName;
            this.SkillName = SkillName;
            this.EmployeeExperience = EmployeeExperience;
        }
    }
}
