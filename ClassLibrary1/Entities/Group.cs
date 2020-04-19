using ClassLibrary1.Entities;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Group : Base
    {
        public Group()
        {
            GroupAttendents = new HashSet<GroupPerson>();
        }

        public Group(
            string name,
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
        public virtual ICollection<GroupPerson> GroupAttendents { get; private set; }
    }
}
