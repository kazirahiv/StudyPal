using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model.Repository
{
    public static class TeacherRepository
    {
        public static StudyPalContext Context = new StudyPalContext();

        public static List<Teacher> GetTeachers()
        {
            return Context.Teachers.ToList();
        }


        public static Teacher GetTeacherById(int id)
        {
            return Context.Teachers.Where(s => s.TeacherId == id).FirstOrDefault();
        }

        public static int RemoveTeacher(Teacher Teacher)
        {
            Context.Teachers.Remove(Teacher);
            return Context.SaveChanges();
        }

        public static int AddTeacher(Teacher Teacher)
        {
            Context.Teachers.Add(Teacher);
            return Context.SaveChanges();
        }

        public static int UpdateTeacher(Teacher Teacher)
        {
            Context.Teachers.Add(Teacher);
            return Context.SaveChanges();
        }

        public static int Save()
        {
            return Context.SaveChanges();
        }

        public static Teacher FindTeacherByUserName(string name)
        {
            return Context.Teachers.Where(s => s.User.UserName.Equals(name)).FirstOrDefault();
        }
    }
}
