using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCompanyDal : EfEntityRepositoryBase<Company, MyDbContext>, ICompanyDal
    {
        public EFCompanyDal()
        {
        }
    }
}
