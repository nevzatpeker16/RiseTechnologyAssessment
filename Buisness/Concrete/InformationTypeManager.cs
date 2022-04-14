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
    public class InformationTypeManager:IInformationTypeService
    {
        IInformationTypeDal _informationTypeDal;


        public InformationTypeManager(IInformationTypeDal informationTypeDal)
        {

            _informationTypeDal = informationTypeDal;
        }

        public IResult AddInformationType(InformationType ınformationType)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteInformationType(InformationType ınformationType)
        {
            _informationTypeDal.Delete(ınformationType);
            return new SuccessResult("Deleted");
        }

        public IDataResult<List<InformationType>> GetInformationTypes()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateInformationType(InformationType ınformationType)
        {
            throw new NotImplementedException();
        }
    }
}
