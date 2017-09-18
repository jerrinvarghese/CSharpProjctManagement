using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Entities
{
    class Project
    {
        public int ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public Project()
        {
        }
        public Project(int ProjectCode, string ProjectName)
        {
            this.ProjectCode = ProjectCode;
            this.ProjectName = ProjectName;
        }
    }
}
