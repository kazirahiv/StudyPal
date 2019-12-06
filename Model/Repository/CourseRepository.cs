using System.Collections.Generic;
using System.Linq;

namespace StudyPal.Model.Repository
{
    public static class CourseRepository
    {
        public static StudyPalContext Context = new StudyPalContext();

        public static List<Course> GetAllCourses()
        {
            return Context.Courses.ToList();
        }


        
        
        public static void AddCourse(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }
    }
}
