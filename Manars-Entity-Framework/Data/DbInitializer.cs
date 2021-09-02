using Manars_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manars_Entity_Framework.Data
{
    public class DbInitializer
    {
        private static IEnumerable<Course> courses;

        public static void Initializer(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-04-01")},
                new Student{FirstMidName="Arturo",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{FirstMidName="Gytis",LastName="Anand",EnrollmentDate=DateTime.Parse("2008-08-01")},
                new Student{FirstMidName="Yan",LastName="Alexander",EnrollmentDate=DateTime.Parse("2000-08-01")},
                new Student{FirstMidName="Puggy",LastName="Justica",EnrollmentDate=DateTime.Parse("2013-10-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2012-11-01")},
                new Student{FirstMidName="Nino",LastName="Olivertto",EnrollmentDate=DateTime.Parse("2008-11-01")}

            };
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050, Title="Chemistry", Credits=3},
                new Course{CourseID=4022, Title="Microeconomics", Credits=3},
                new Course{CourseID=4041, Title="Chemistry", Credits=3},
                new Course{CourseID=1045, Title="Calculus", Credits=4},
                new Course{CourseID=3141, Title="Trigenometry", Credits=4},
                new Course{CourseID=2021, Title="Composition", Credits=3},
                new Course{CourseID=2042, Title="Literature", Credits=4}

            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges(); //we should use this function in CRUD in DB usage 

            var enrollment = new Enrollment[]
            {
                new Enrollment{ StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{ StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{ StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{ StudentID=2,CourseID=1050,Grade=Grade.B},
                new Enrollment{ StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{ StudentID=2,CourseID=2042,Grade=Grade.F},
                new Enrollment{ StudentID=3,CourseID=3141},
                new Enrollment{ StudentID=4,CourseID=3141},
                new Enrollment{ StudentID=4,CourseID=1050,Grade=Grade.F},
                new Enrollment{ StudentID=5,CourseID=2021,Grade=Grade.C},
                new Enrollment{ StudentID=6,CourseID=4041},
                new Enrollment{ StudentID=7,CourseID=1050,Grade=Grade.A},
            };

            foreach (Enrollment e in enrollment)
            {
                context.Enrollmens.Add(e);
            }

            context.SaveChanges();
        }

        internal static void Initialize(SchoolContext context)
        {
            throw new NotImplementedException();
        }
    }
}
