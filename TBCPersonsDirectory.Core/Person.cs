﻿using System;
using System.Collections.Generic;

namespace TBCPersonsDirectory.Core
{
    public class Person : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        public string PrivateNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<PersonPhoneNumber> PhoneNumbers { get; set; }
    }
}
