using Application.AppCourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Path
{
    public class CreatePathModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<CreateCourseModel> Courses { get; set; }
    }
}
