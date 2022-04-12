using Entities.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonInformationDetail:IEntity
    {
        public Guid PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public Company PersonCompany { get; set; }
        public List<PersonInformation> ContactInformations { get; set; }
    }
}
