using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model.Repository
{
    public static class StudentRepository
    {
        public static StudyPalContext Context = new StudyPalContext();

        public static List<Student> GetStudents()
        {
            return Context.Students.ToList();
        }


        public static Student GetStudentById(int id)
        {
            return Context.Students.Where(s => s.StudentId == id).FirstOrDefault();
        }

        public static int RemoveStudent(Student student)
        {
            Context.Students.Remove(student);
            return Context.SaveChanges();
        }

        public static int AddStudent(Student student)
        {
            Context.Students.Add(student);
            return Context.SaveChanges();
        }

        public static int UpdateStudent(Student student)
        {
            Context.Students.Add(student);
            return Context.SaveChanges();
        }

        public static int Save()
        {
            return Context.SaveChanges();
        }


        public static Student FindStudentByUserName(string name)
        {
            return Context.Students.Where(s => s.User.UserName.Equals(name)).FirstOrDefault();
        }
    }
}
