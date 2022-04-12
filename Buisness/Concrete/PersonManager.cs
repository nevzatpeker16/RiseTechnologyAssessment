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
        IPersonInformationDal _personInformationDal;

        public PersonManager(IPersonDal personDal,IPersonInformationDal personInformationDal)
        {
            _personDal = personDal;
            _personInformationDal = personInformationDal;
        }

        public void AddPerson(Person person)
        {
            _personDal.Add(person);

        }

        public List<Person> GetAllPersons()
        {
            return new List<Person>(_personDal.getAll());
        }

        public List<Person> getPersonByContactInformation(string contactInformation)
        {
            return new List<Person>(_personDal.getAll(p => p.Informations.Contains(_personInformationDal.Get(ci=>ci.InfoType.Type == contactInformation))));

        }

        public List<Person> getPersonByInformation(PersonInformation contactInformation)
        {
            return new List<Person>(_personDal.getAll(p => p.Informations.Contains(contactInformation)));
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
