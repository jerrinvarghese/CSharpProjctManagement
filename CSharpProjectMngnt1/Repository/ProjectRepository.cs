using CSharpProjectMngnt1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Repository
{
    class ProjectRepository
    {
        List<Project> projectList = new List<Project>();
        public void AddProject(Project project)
        {
            Console.WriteLine("Enter Project Code");
            int projectCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Project Name");
            string projectName = Console.ReadLine();
            projectList.Add(new Project(projectCode, projectName));
        }
    }
}
