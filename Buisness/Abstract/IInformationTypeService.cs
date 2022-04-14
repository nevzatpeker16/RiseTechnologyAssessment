using Core.Utilities.Results.Abstract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IInformationTypeService
    {

        IResult AddInformationType(InformationType ınformationType);
        IResult DeleteInformationType(InformationType ınformationType);

        IResult UpdateInformationType(InformationType ınformationType);

        IDataResult<List<InformationType>> GetInformationTypes();

    }
}
