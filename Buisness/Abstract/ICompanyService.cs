using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICompanyService
    {
        void AddCompany(Company company);
        
        void RemoveCompany(Company company);
        void UpdateCompany(Company company);

        List<Company> GetCompanies();

        Company GetCompanyByPerson(Person person);


    }
}
