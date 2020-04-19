namespace ClassLibrary1.Entities
{
    public class PersonContact : Base
    {
        public PersonContact()
        {

        }
        public PersonContact(int personcontacttypeId, 
            int personId) : this()
        {
            PersonContactTypetId = personcontacttypeId;
            PersonId = personId;
        }

        public int PersonContactTypetId { get; set; }
        public int PersonId { get; set; }
        public string Contact { get; set; }

        public virtual PersonContactType PersonContactType { get; set; }
        public virtual Person Person { get; set; }
    }
}
