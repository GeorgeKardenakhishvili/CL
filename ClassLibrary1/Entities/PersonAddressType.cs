using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class PersonAddressType : Base
    {
        public PersonAddressType()
        {
            PersonAddresses = new HashSet<PersonAddress>();
        }

        public PersonAddressType(string name) : this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; private set; }
    }
}
