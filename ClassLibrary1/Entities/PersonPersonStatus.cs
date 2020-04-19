using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class PersonPersonStatus : Base
    {
        public PersonPersonStatus()
        {

        }

        public PersonPersonStatus(int personId,
            int personstatusId) : this()
        {
            PersonId = personId;
            PersonStatusId = personstatusId;
        }

        public int PersonId { get; set; }
        public int PersonStatusId { get; set; }

        public virtual Person Person { get; set; }
        public virtual PersonStatus PersonStatus { get; set; }
    }
}
