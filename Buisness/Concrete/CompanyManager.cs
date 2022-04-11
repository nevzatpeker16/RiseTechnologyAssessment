using Buisness.Abstract;
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

        public void AddCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyByPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void RemoveCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
