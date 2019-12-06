using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class StudyPalContext : DbContext
    {
        public StudyPalContext() : base("name=StudyPalDb")
        {
            Database.SetInitializer(new StudyPalDbInitializer());
            Database.Initialize(true);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Payment> Payments{ get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TuitionRequest> TuitionRequests { get; set; }
    }
}
