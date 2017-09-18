using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMngnt1.Entities
{
    class Skill
    {
        public int SkillCode { get; set; }
        public string SkillName { get; set; }
        public Skill()
        {
        }
        public Skill(int SkillCode, string SkillName)
        {
            this.SkillCode = SkillCode;
            this.SkillName = SkillName;
        }
    }
}
