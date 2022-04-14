using Buisness.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class CompanyManager:ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult AddCompany(Company company)
        {
            _companyDal.Add(company);
            return new Result(true);
        }
        public IDataResult<List<Company>> GetCompanies()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.getAll());

        }
        public IDataResult<Company> GetCompanyByPerson(Person person)
        {
            return  new SuccessDataResult<Company>((_companyDal.Get(c => c.ID == person.PersonCompany.ID)));

        }

        public IResult RemoveCompany(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult();
        }
        public IResult UpdateCompany(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult();
        }
    }
}
