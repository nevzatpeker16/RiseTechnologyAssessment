using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class PersonInformationManager:IPersonInformationService
    {
        IPersonInformationDal _personInformationDal;

        public void AddContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public List<PersonInformation> GetPersonInformations()
        {
            throw new NotImplementedException();
        }

        public List<PersonInformation> GetPersonInformationsByPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void RemoveContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public void UpdateContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }
    }
}
