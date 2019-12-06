using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model.Repository
{
    class SkillRepository
    {
        public static StudyPalContext Context = new StudyPalContext();

        public static List<Skill> GetSkills()
        {
            return Context.Skills.ToList();
        }


        public static Skill GetSkillById(int id)
        {
            return Context.Skills.Where(s => s.SkillId == id).FirstOrDefault();
        }

        public static int RemoveSkill(Skill Skill)
        {
            Context.Skills.Remove(Skill);
            return Context.SaveChanges();
        }

        public static int AddSkill(Skill Skill)
        {
            Context.Skills.Add(Skill);
            return Context.SaveChanges();
        }

        public static int AddSkills(List<Skill> Skills)
        {
            Context.Skills.AddRange(Skills);
            return Context.SaveChanges();
        }

        public static int UpdateSkill(Skill Skill)
        {
            Context.Skills.Add(Skill);
            return Context.SaveChanges();
        }

        public static int Save()
        {
            return Context.SaveChanges();
        }


        public static Skill FindSkillById(int id)
        {
            return Context.Skills.Where(s => s.SkillId == id).FirstOrDefault();
        }
    }
}
