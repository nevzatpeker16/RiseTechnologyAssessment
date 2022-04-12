using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerate
{
    public class Person:IEntity
    {
        public Person()
        {
            ID = new Guid();
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<PersonInformation> Informations { get; set; }

        public virtual Company PersonCompany { get; set; }

    }
}
