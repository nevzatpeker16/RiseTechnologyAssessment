using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFInformationTypeDal:EfEntityRepositoryBase<InformationType , MyDbContext>,IInformationTypeDal
    {

        public EFInformationTypeDal()
        {

        }
    }
}
