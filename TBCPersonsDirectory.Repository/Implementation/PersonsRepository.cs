﻿using TBCPersonsDirectory.Core;
using TBCPersonsDirectory.Repository.EF;
using TBCPersonsDirectory.Repository.Interfaces;

namespace TBCPersonsDirectory.Repository.Implementation
{
    public class PersonsRepository : BaseRepository<Person, int>, IPersonsRepository
    {
        public PersonsRepository(PersonsDbContext context) : base(context)
        {
        }
    }
}
