using FluentValidation;
using Ninject.Modules;
using ZeyrekFramework.Business.ValidationRules.FluentValidation;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Message>>().To<MessageValidatior>().InSingletonScope();
        }
    }
}
