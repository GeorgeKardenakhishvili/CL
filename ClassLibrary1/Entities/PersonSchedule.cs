namespace ClassLibrary1.Entities
{
    public class PersonSchedule : Base
    {
        public PersonSchedule()
        {

        }
        public PersonSchedule(int scheduleId,
            bool presence) : this()
        {
            ScheduleId = scheduleId;
            Presence = presence;
        }

        public int ScheduleId { get; set; }
        public bool Presence { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
