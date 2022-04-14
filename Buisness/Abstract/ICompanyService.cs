using Core.Utilities.Results.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICompanyService
    {
        IResult AddCompany(Company company);

        IResult RemoveCompany(Company company);
        IResult UpdateCompany(Company company);

        IDataResult<List<Company>> GetCompanies();

        IDataResult<Company> GetCompanyByPerson(Person person);


    }
}
