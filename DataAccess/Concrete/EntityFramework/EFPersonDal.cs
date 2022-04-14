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
            return null;
        }
    }
}
