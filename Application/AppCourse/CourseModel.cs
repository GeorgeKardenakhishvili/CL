using Application.Path;
using ClassLibrary1;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.AppCourse
{
    public class CourseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PathModel Path { get; set; }
    }
}
