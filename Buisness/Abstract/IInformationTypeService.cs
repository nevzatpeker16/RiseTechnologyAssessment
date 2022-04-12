using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IInformationTypeService
    {

        void AddInformationType(InformationType ınformationType);
        void DeleteInformationType(InformationType ınformationType);

        void UpdateInformationType(InformationType ınformationType);

        List<InformationType> GetInformationTypes();

    }
}
