using ClassLibrary1;
using ClassLibrary1.Entities;
using System.Collections.Generic;

namespace Application.AppCourse
{
    public class UpdateCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PathId { get; set; }
    }
}
