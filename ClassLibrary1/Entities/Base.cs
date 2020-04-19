using System;

namespace ClassLibrary1.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public int? CreateCustomerId { get; set; }
        public string CreateAppId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? LastModifiedCustomerId { get; set; }
        public string LastModifiedAppId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsHidden { get; set; }
        //public virtual Customer CreateCustomer { get; set; }
        //public virtual Customer LastModifiedCustomer { get; set; }
    }
}
