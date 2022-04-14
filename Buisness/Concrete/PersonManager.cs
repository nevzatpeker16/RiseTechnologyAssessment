using Buisness.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concerate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        IPersonInformationDal _personInformationDal;

        public PersonManager(IPersonDal personDal,IPersonInformationDal personInformationDal)
        {
            _personDal = personDal;
            _personInformationDal = personInformationDal;
        }

        public IResult AddPerson(Person person)
        {
            _personDal.Add(person);
            throw new NotImplementedException();

        }

        public IDataResult<List<Person>> GetAllPersons()
        {
            return new SuccessDataResult<List<Person>>(_personDal.getAll());
        }

        public IDataResult<List<Person>> getPersonByContactInformation(string contactInformation)
        {
            return new SuccessDataResult<List<Person>>(_personDal.getAll(p => p.Informations.Contains(_personInformationDal.Get(ci=>ci.InfoType.Type == contactInformation))));

        }

        public IDataResult<List<Person>> getPersonByInformation(PersonInformation contactInformation)
        {
            return new SuccessDataResult<List<Person>>(_personDal.getAll(p => p.Informations.Contains(contactInformation)));
        }

        public IDataResult<List<PersonInformationDetail>> personalInformationDetails(Person person)
        {
            throw new NotImplementedException();

        }

        public IResult RemovePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public IResult UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
