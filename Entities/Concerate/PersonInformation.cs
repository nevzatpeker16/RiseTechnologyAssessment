using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerate
{
    public class PersonInformation:IEntity
    {
        public PersonInformation()
        {
            ID = new Guid();
        }

        public Guid ID { get; set; }

        public  virtual InformationType InfoType { get; set; }

        public string Information { get; set; }

    }
}
