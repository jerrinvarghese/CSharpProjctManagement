using CSharpProjectMngnt1.BusinessServices;
using CSharpProjectMngnt1.Entities;
using CSharpProjectMngnt1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1
{
    class Program
    {
        
            static Employee employee = new Employee();
            static Project project = new Project();
            static Skill skill = new Skill();
            static EmployeeProject employeeProject = new EmployeeProject();
            static EmployeeSkills employeeSkill = new EmployeeSkills();
            static EmployeeRepository employeeRepository = new EmployeeRepository();
            static ProjectRepository projectRepository = new ProjectRepository();
            static SkillRepository skillRepository = new SkillRepository();
            static List<Employee> employeeList = new List<Employee>();
            static List<EmployeeSkills> employeeSkills = new List<EmployeeSkills>();
            static List<EmployeeProject> employeeProjects = new List<EmployeeProject>();
            static void Main(string[] args)
        {
                bool Continue = true;
                do
                {
                    Console.WriteLine("1. Add Project");
                    Console.WriteLine("2. Add Skill");
                    Console.WriteLine("3. Add Employee");
                    Console.WriteLine("4. Add Skill to Employee");
                    Console.WriteLine("5. Map Employee to Project");
                    Console.WriteLine("6. Search Employee by Name");
                    Console.WriteLine("7. Search Employee by Project");
                    Console.WriteLine("8. Search Employee by Skill");
                    Console.WriteLine("9. Exit");
                    Console.WriteLine("Enter option:");
                    int option;
                    bool isValid = int.TryParse(Console.ReadLine(), out option);
                    if (isValid)
                    {
                        switch (option)
                        {
                            case 1:
                                projectRepository.AddProject(project);
                                break;
                            case 2:
                                skillRepository.AddSkill(skill);
                                break;
                            case 3:
                                employeeRepository.AddEmployee(employeeList);
                                break;
                            case 4:
                                employeeRepository.AddEmployeeSkill(employeeSkills);
                                break;
                            case 5:
                                employeeRepository.AddEmployeeProject(employeeProjects);
                                break;
                            case 6:
                                Employee emp = employeeRepository.GetEmployeeByName(employeeList);
                                Console.WriteLine("Employee Code: " + emp.EmployeeCode);
                                Console.WriteLine("Employee Name: " + emp.EmployeeName);
                                Console.WriteLine("Experience: " + emp.Experience);
                                Console.WriteLine("Age: " + emp.EmployeeAge);
                                break;
                            case 7:
                                EmployeeProject empProject = employeeRepository.GetEmployeeByProject(employeeProjects);
                                Console.WriteLine("Employee Name: " + empProject.EmployeeName);
                                Console.WriteLine("Project: " + empProject.Project);
                                break;
                            case 8:
                                EmployeeSkills empSkill = employeeRepository.GetEmployeeBySkill(employeeSkills);
                                Console.WriteLine("Employee Name: " + empSkill.EmployeeName);
                                Console.WriteLine("Skill: " + empSkill.SkillName);
                                Console.WriteLine("Experience: " + empSkill.EmployeeExperience);
                                break;
                            case 9:
                                Continue = false;
                                break;
                            default:
                                Console.WriteLine("invalid option!!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter option number");
                    }
                } while (Continue);
            }
        }
    }

