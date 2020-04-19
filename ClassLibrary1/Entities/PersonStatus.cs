using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class PersonStatus : Base
    {
        public PersonStatus()
        {
            StatusPeople = new HashSet<PersonPersonStatus>();
            SchedulePeople = new HashSet<SchedulePerson>();
            GroupPeople = new HashSet<GroupPerson>();
        }
        public PersonStatus(string status) : this()
        {
            Name = status;
        }
        public string Name { get; set; }
        public virtual ICollection<PersonPersonStatus> StatusPeople { get; set; }
        public virtual ICollection<SchedulePerson> SchedulePeople { get; set; }
        public virtual ICollection<GroupPerson> GroupPeople { get; set; }
    }
}
