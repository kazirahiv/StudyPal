using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
    }
}
