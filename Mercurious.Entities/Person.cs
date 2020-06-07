using Mercurius.Entities.Interfaces;
using System;

namespace Mercurius.Entities
{
    public abstract class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        //IEnumerable<PersonContactInfo> PersonContactInfoList { get; set; }
    }
}
