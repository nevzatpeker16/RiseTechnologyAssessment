using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class InformationTypeManager:IInformationTypeService
    {
        IInformationTypeDal _informationTypeDal;


        public InformationTypeManager(IInformationTypeDal informationTypeDal)
        {

            _informationTypeDal = informationTypeDal;
        }

        public void AddInformationType(InformationType ınformationType)
        {
            throw new NotImplementedException();
        }

        public void DeleteInformationType(InformationType ınformationType)
        {
            throw new NotImplementedException();
        }

        public List<InformationType> GetInformationTypes()
        {
            throw new NotImplementedException();
        }

        public void UpdateInformationType(InformationType ınformationType)
        {
            throw new NotImplementedException();
        }
    }
}
