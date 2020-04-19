using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class Schedule : Base
    {
        public Schedule()
        {
            PersonSchedules = new HashSet<PersonSchedule>();
            SubjectSchedules = new HashSet<SubjectSchedule>();
            SchedulePeople = new HashSet<SchedulePerson>();
        }
        public Schedule(DateTime startDate,
            DateTime endDate) : this()
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<PersonSchedule> PersonSchedules { get; set; }
        public virtual ICollection<SubjectSchedule> SubjectSchedules { get; private set; }
        public virtual ICollection<SchedulePerson> SchedulePeople { get; private set; }
    }
}
