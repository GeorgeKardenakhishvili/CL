

namespace ClassLibrary1.Entities
{
    public class GroupPerson : Base
    {
        public GroupPerson()
        {

        }
        public GroupPerson(int groupId,
            int personId,
            int personStatusId) : this()
        {
            GroupId = groupId;
            PersonId = personId;
            PersonStatusId = personStatusId;
        }

        public int GroupId { get; set; }
        public int PersonId { get; set; }
        public int PersonStatusId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Person Person { get; set; }
        public virtual PersonStatus PersonStatus { get; set; }
    }
}
