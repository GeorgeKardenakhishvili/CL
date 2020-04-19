using Application.AppCourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Path
{
    public class CreatePathDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<CreateCourseDto> Courses { get; set; }
    }
}
