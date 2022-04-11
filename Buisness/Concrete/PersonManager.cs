using Buisness.Abstract;
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

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public List<Person> getPersonByContactInformation(string contactInformation)
        {
            throw new NotImplementedException();
        }

        public List<Person> getPersonByInformation(PersonInformation contactInformation)
        {
            throw new NotImplementedException();
        }

        public List<PersonInformationDetail> personalInformationDetails(Person person)
        {
            throw new NotImplementedException();
        }

        public void RemovePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
