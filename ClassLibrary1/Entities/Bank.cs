using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class Bank : Base
    {
        public Bank()
        {
            PersonBankAccounts = new HashSet<PersonBankAccount>();
        }

        public Bank(string name) : this()
        {
            Name = name;
        }
        
        public string Name { get; set; }
        public virtual ICollection<PersonBankAccount> PersonBankAccounts { get; private set; }
    }
}
