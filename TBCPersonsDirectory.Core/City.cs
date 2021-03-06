﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TBCPersonsDirectory.Core
{
    public class City
    {
        public City() { }

        public City(int id, string name) : base()
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
