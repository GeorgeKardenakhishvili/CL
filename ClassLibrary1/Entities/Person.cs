using System;
using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class Person : Base
    {
        public Person()
        {
            PersonContacts = new HashSet<PersonContact>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonBankAccounts = new HashSet<PersonBankAccount>();
            PersonPersonStatuses = new HashSet<PersonPersonStatus>();
            GroupPeople = new HashSet<GroupPerson>();
            SchedulePeople = new HashSet<SchedulePerson>();
        }

        public Person(string personNo,
            string identityNo,
            string firstname,
            string lastname,
            string firstnameEn,
            string lastnameEn,
            DateTime birthdate,
            int personTypeId) : this()
        {
            PersonNo = personNo;
            IdentityNo = identityNo;
            FirstName = firstname;
            LastName = lastname;
            FirstNameEn = firstnameEn;
            LastNameEn = lastnameEn;
            BirthDate = birthdate;
            PersonTypeId = personTypeId;
        }

        public string PersonNo { get; set; }
        public string IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
        public DateTime BirthDate { get; set; }
        public int PersonTypeId { get; set; }

        public virtual PersonType PersonType { get; set; }
        public virtual ICollection<PersonContact> PersonContacts { get; private set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; private set; }
        public virtual ICollection<PersonBankAccount> PersonBankAccounts { get; private set; }
        public virtual ICollection<PersonPersonStatus> PersonPersonStatuses { get; private set; }
        public virtual ICollection<GroupPerson> GroupPeople { get; private set; }
        public virtual ICollection<SchedulePerson> SchedulePeople { get; private set; }
    }
}
