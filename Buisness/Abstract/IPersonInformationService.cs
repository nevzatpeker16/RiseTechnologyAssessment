using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPersonInformationService
    {
        void AddPersonInformation(PersonInformation personInformation);
        void RemovePersonInformation(PersonInformation personInformation);

        void UpdatePersonInformation(PersonInformation personInformation);

        List<PersonInformation> GetPersonInformations();

        List<PersonInformation> GetPersonInformationsByPerson(Person  person);


    }
}
