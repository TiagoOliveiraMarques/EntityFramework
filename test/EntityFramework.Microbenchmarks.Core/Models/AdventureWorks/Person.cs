// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace EntityFramework.Microbenchmarks.Core.Models.AdventureWorks
{
    public class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public int BusinessEntityID { get; set; }
        public int EmailPromotion { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool NameStyle { get; set; }
        public string PersonType { get; set; }
        public Guid rowguid { get; set; }
        public string Suffix { get; set; }
        public string Title { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}