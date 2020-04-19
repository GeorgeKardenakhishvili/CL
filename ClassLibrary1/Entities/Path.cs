using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Path : Base
    {
        public Path()
        {
            Courses = new HashSet<Course>();
        }

        public Path(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; private set; }

        public Path AddCourses(params Course[] courses)
        {
            foreach (var item in courses)
            {
                Courses.Add(item);
            }
            return this;
        }
    }
}
