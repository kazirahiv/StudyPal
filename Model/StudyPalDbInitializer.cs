using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    class StudyPalDbInitializer : DropCreateDatabaseIfModelChanges<StudyPalContext>
    {
        protected override void Seed(StudyPalContext context)
        {
            //Add default courses 
            List<Course> defaultCourses = new List<Course>();
            defaultCourses.Add(new Course() { CourseName = "Object Oriented Programming 1", CourseCode="1001" });
            defaultCourses.Add(new Course() { CourseName = "Object Oriented Programming 2", CourseCode = "1002" });
            defaultCourses.Add(new Course() { CourseName = "DataStructure", CourseCode="1003" });
            defaultCourses.Add(new Course() { CourseName = "Introduction to Database", CourseCode="1004" });
            defaultCourses.Add(new Course() { CourseName = "Physics 1", CourseCode="1005" });
            defaultCourses.Add(new Course() { CourseName = "Business Communications", CourseCode="1006" });
            defaultCourses.Add(new Course() { CourseName = "Software Engineering", CourseCode="1007" });
            context.Courses.AddRange(defaultCourses);

            //Add a default admin user
            User user = new User();
            user.Name = "Kazi Rahiv";
            user.UserName = "rahivjobs@gmail.com";


            base.Seed(context);
            context.SaveChanges();
        }
    }
}
