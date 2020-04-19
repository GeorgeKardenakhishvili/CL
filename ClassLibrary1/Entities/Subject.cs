using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class Subject : Base
    {
        public Subject()
        {
            SubjectSchedules = new HashSet<SubjectSchedule>();
        }

        public Subject(string name,
            string description,
            int courseId) : this()
        {
            Name = name;
            Description = description;
            CourseId = courseId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<SubjectSchedule> SubjectSchedules { get; private set; }
    }
}
