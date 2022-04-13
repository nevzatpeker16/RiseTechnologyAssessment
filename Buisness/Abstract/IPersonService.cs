using Core.Utilities.Results.Abstract;
using Entities.Concerate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPersonService
    {
        IResult AddPerson(Person person);
        IResult RemovePerson(Person person);

        IResult UpdatePerson(Person person);

        IDataResult<List<Person>> GetAllPersons();

        IDataResult<List<Person>> getPersonByInformation(PersonInformation contactInformation);

        IDataResult<List<Person>> getPersonByContactInformation(string  contactInformation);

        IDataResult<List<PersonInformationDetail>> personalInformationDetails(Person person);


    }
}
