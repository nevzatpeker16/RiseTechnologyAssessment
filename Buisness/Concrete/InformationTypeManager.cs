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

            if(ınformationType.Type.Length > 0)
            {
                _informationTypeDal.Add(ınformationType);

            }


        }

        public void DeleteInformationType(InformationType ınformationType)
        {

            _informationTypeDal.Delete(ınformationType);
        }

        public List<InformationType> GetInformationTypes()
        {
            return new List<InformationType>(_informationTypeDal.getAll());

        }

        public void UpdateInformationType(InformationType ınformationType)
        {
            _informationTypeDal.Update(ınformationType);
        }
    }
}
