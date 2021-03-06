using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manars_Entity_Framework.Models
{

        public enum Grade
        {
            A, B, C, D, F
        }

        public class Enrollment
        {
            public int EnrollmentID { get; set; }
            public int CourseID { get; set; }
            public int StudentID { get; set; }
            public Grade? Grade { get; set; }

            public Course Cource { get; set; }
            public Student Student { get; set; }
        }

}
