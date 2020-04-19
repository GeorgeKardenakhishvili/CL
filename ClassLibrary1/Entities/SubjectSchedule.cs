using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class SubjectSchedule : Base
    {
        public SubjectSchedule()
        {

        }
        public SubjectSchedule(int subjectId,
            int scheduleId) : this()
        {
            SubjectId = subjectId;
            ScheduleId = scheduleId;
        }
        
        public int SubjectId { get; set; }
        public int ScheduleId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
