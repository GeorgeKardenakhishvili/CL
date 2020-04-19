using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class SchedulePerson : Base
    {
        public SchedulePerson()
        {

        }
        public SchedulePerson(int personId,
            int scheduleId,
            int personstatusId) : this()
        {
            PersonId = personId;
            ScheduleId = scheduleId;
            PersonStatusId = personstatusId;
        }

        public int PersonId { get; set; }
        public int ScheduleId { get; set; }
        public int PersonStatusId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual PersonStatus PersonStatus { get; set; }
    }
}
