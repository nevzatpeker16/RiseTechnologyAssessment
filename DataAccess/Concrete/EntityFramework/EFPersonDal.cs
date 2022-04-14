using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concerate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFPersonDal:EfEntityRepositoryBase<Person,MyDbContext>,IPersonDal
    {
        public EFPersonDal()
        {
                
        }


        public List<PersonInformationDetail> GetPersonInformationDetails(Person person)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var result = from pe in dbContext.Persons
                             join c in dbContext.Companies on pe.CompanyID equals c.CompanyID
                             join pı in dbContext.PersonInformation on pe.ID equals pı.PersonID
                             where pe.ID == person.ID
                             select new PersonInformationDetail
                             {
                                 PersonID = pe.ID,
                                 PersonName = pe.Name,
                                 PersonSurname = pe.Surname,
                                 PersonCompany = c.Company,
                                 ContactInformations = pı.ContactInformations,
                             };

                return result;
            }
        }
    }
}
