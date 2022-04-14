using Autofac;
using Buisness.Abstract;
using Buisness.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Buisness.DependencyResolvers.Autofac
{
    public class AutofacBuisnessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
               
            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<InformationTypeManager>().As<IInformationTypeService>().SingleInstance();
            builder.RegisterType<PersonInformationManager>().As<IPersonInformationService>().SingleInstance();
            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();


        }
    }
}
