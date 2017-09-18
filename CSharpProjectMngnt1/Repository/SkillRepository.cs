using CSharpProjectMngnt1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Repository
{
    class SkillRepository
    {
        List<Skill> skillList = new List<Skill>();
        public void AddSkill(Skill skill)
        {
            Console.WriteLine("Enter Skill Code");
            int skillCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Skill Name");
            string skillName = Console.ReadLine();
            skillList.Add(new Skill(skillCode, skillName));
        }
    }
}
