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
            _companyDal.Add(company);
        }

        public List<Company> GetCompanies()
        {
            return new List<Company>(_companyDal.getAll());
        }

        public Company GetCompanyByPerson(Person person)
        {
            return (_companyDal.Get(c => c.ID == person.PersonCompany.ID));
        }

        public void RemoveCompany(Company company)
        {
            _companyDal.Delete(company);

        }

        public void UpdateCompany(Company company)
        {
            _companyDal.Update(company);
        }
    }
}
