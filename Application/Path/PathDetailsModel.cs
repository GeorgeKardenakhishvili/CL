using Application.AppCourse;
using Application.Course;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Path
{
    public class PathDetailsModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<CourseModel> Courses { get; private set; }
    }
}
