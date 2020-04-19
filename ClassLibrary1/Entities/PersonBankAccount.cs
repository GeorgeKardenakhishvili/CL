namespace ClassLibrary1.Entities
{
    public class PersonBankAccount : Base
    {
        public PersonBankAccount()
        {

        }
        public PersonBankAccount(int personId,
            int bankId) : this()
        {
            PersonId = personId;
            BankId = bankId;
        }

        public int PersonId { get; set; }
        public int BankId { get; set; }
        public string AccountNumber { get; set; }

        public virtual Person Person { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
