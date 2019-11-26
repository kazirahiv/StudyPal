using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    class StudyPalContext : DbContext
    {
        public StudyPalContext() : base("name=studyPalDb") { }

        public DbSet<Course> CourseList { get; set; }
    }
}
