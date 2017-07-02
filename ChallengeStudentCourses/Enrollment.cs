using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Enrollment
    {
        public Course course { get; set; }
        public Student student { get; set; }
        public int grade { get; set; }
    }
}