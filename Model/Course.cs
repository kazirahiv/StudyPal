using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public int CourseName { get; set; }
    }
}
