﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TBCPersonsDirectory.Core
{
    public class PhoneNumberType
    {
        public PhoneNumberType() { }
        public PhoneNumberType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
