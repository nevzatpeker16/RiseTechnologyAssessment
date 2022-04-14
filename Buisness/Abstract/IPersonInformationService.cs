using Core.Utilities.Results.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPersonInformationService
    {
        IResult AddPersonInformation(PersonInformation personInformation);
        IResult RemovePersonInformation(PersonInformation personInformation);

        IResult UpdatePersonInformation(PersonInformation personInformation);

        IDataResult<List<PersonInformation>> GetPersonInformations();

        IDataResult<List<PersonInformation>> GetPersonInformationsByPerson(Person  person);


    }
}
