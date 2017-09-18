using CSharpProjectMngnt1.BusinessServices;
using CSharpProjectMngnt1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Repository
{
    class EmployeeRepository
    {
        public void AddEmployee(List<Employee> employeeList)
        {
            Console.WriteLine("Enter Employee Code");
            int employeeCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Years of Experience");
            int employeeExperience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age");
            int employeeAge = Convert.ToInt32(Console.ReadLine());
            employeeList.Add(new Employee(employeeCode, employeeName, employeeExperience, employeeAge));
        }
        public void AddEmployeeSkill(List<EmployeeSkills> employeeSkills)
        {
            Console.WriteLine("Enter Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Skill");
            string skill = Console.ReadLine();
            Console.WriteLine("Enter Experience");
            int experience = Convert.ToInt32(Console.ReadLine());
            employeeSkills.Add(new EmployeeSkills(employeeName, skill, experience));
        }
        public void AddEmployeeProject(List<EmployeeProject> employeeProjects)
        {
            Console.WriteLine("Enter Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Project");
            string project = Console.ReadLine();
            employeeProjects.Add(new EmployeeProject(employeeName, project));
        }
        public Employee GetEmployeeByName(List<Employee> employeeList)
        {
            Console.WriteLine("Enter Employee Name");
            string employeeName = Console.ReadLine();
            return employeeList.FirstOrDefault(x => x.EmployeeName == employeeName);

        }
        public EmployeeProject GetEmployeeByProject(List<EmployeeProject> employeeProjects)
        {
            Console.WriteLine("Enter Project");
            string project = Console.ReadLine();
            return employeeProjects.FirstOrDefault(x => x.Project == project);

        }
        public EmployeeSkills GetEmployeeBySkill(List<EmployeeSkills> employeeSkills)
        {
            Console.WriteLine("Enter Skill");
            string skill = Console.ReadLine();
            return employeeSkills.FirstOrDefault(x => x.SkillName == skill);
        }
    }
}
