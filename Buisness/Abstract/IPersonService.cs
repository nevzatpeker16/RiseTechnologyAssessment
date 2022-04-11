using Entities.Concerate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        void RemovePerson(Person person);

        void UpdatePerson(Person person);

        List<Person> GetAllPersons();

        List<Person> getPersonByInformation(PersonInformation contactInformation);

        List<Person> getPersonByContactInformation(string  contactInformation);

        List<PersonInformationDetail> personalInformationDetails(Person person);


    }
}
