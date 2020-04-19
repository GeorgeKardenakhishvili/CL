namespace ClassLibrary1.Entities
{
    public class PersonAddress : Base
    {
        public PersonAddress()
        {

        }
        public PersonAddress(int personadressTypeId, 
            int personId,
            string address) : this()
        {
            PersonAddressTypeId = personadressTypeId;
            PersonId = personId;
            Address = address;
        }
        
        public int PersonId { get; set; }
        public int PersonAddressTypeId { get; set; }
        public string Address { get; set; }
        
        public virtual PersonAddressType PersonAddressType { get; set; }
        public virtual Person Person { get; set; }
    }
}
