using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPersonInformationService
    {
        void AddContactInformation(PersonInformation contactInformation);
        void RemoveContactInformation(PersonInformation contactInformation);

        void UpdateContactInformation(PersonInformation contactInformation);

        List<PersonInformation> GetPersonInformations();

        List<PersonInformation> GetPersonInformationsByPerson(Person  person);


    }
}
