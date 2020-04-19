using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class PersonContactType : Base
    {
        public PersonContactType()
        {
            PersonContacts = new HashSet<PersonContact>();
        }

        public PersonContactType(string name) : this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public virtual ICollection<PersonContact> PersonContacts { get; private set; }
    }
}
