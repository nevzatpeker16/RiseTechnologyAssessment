using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerate
{
    public class ContactInformation:IEntity
    {
        public Guid Id { get; set; }

        public  virtual InformationType InfoType { get; set; }

        public string Information { get; set; }

    }
}
