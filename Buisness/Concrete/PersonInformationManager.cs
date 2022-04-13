using Buisness.Abstract;
using Core.Utilities.Results.Abstract;
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

        public IResult AddContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public IResult AddPersonInformation(PersonInformation personInformation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonInformation>> GetPersonInformations()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonInformation>> GetPersonInformationsByPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public IResult RemoveContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public IResult RemovePersonInformation(PersonInformation personInformation)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateContactInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public IResult UpdatePersonInformation(PersonInformation personInformation)
        {
            throw new NotImplementedException();
        }
    }
}
