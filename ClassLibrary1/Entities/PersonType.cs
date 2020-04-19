using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class PersonType : Base
    {
        public PersonType()
        {
            People = new HashSet<Person>();
        }

        public PersonType(string name) : this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public virtual ICollection<Person> People { get; private set; }
    }
}
