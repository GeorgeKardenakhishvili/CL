using ClassLibrary1.Entities;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Course : Base
    {
        public Course()
        {
            Groups = new HashSet<Group>();
            Subjects = new HashSet<Subject>();
        }

        public Course(string name,
            string description,
            int pathId) : this()
        {
            Name = name;
            Description = description;
            PathId = pathId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int PathId { get; set; }

        public virtual Path Path { get; set; }

        public virtual ICollection<Group> Groups { get; private set; }

        public virtual ICollection<Subject> Subjects { get; private set; }
    }
}
